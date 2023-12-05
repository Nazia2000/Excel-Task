using Patient_Information_Protal_Backend_Web_Api.Models.Data;
using Patient_Information_Protal_Backend_Web_Api.Models.DBEntity;

namespace Patient_Information_Protal_Backend_Web_Api.Repositories
{
    public class GenericRepository : IGenericRepository<Patient, int, bool>
    {
        private readonly ApplicationDbContext db;
        public GenericRepository(ApplicationDbContext db)
        {
            this.db = db;
        }




        public bool Add(Patient patient)
        {
            if (patient != null)
            {
                db.Patients.Add(patient);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            var ext = db.Patients.Find(id);
            db.Patients.Remove(ext);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Patient> GetAll()
        {
            var data = db.Patients.ToList();
            if (data != null)
            {
                return data;
            }
            else
            {
                return null;
            }
        }

        public Patient GetById(int id)
        {
            var patient = db.Patients.Find(id);
            if (patient != null)
            {
                return patient;
            }
            else
            {
                return null;
            }
        }

        public bool Update(int id, Patient patient)
        {
            var ext = db.Patients.Find(id);
            db.Entry(ext).CurrentValues.SetValues(patient);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public interface IGenericRepository<TClass, TId, TResult> 
    {
        IEnumerable<TClass> GetAll();
        TClass GetById(TId id);
        TResult Add(TClass obj);
        TResult Delete(TId id);
        TResult Update(TId id, TClass obj);

    }
}
