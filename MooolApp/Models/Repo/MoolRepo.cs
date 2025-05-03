namespace MooolApp.Models.Repo
{
    public class MoolRepo
    {
        private readonly DbMool _db;

        public MoolRepo(DbMool db)
        {
            _db = db;
        }

        public List<Mool> GetAll()
        {
            var mo = _db.Mools.ToList();
            return mo;
        }

        public Mool InsertMoll(Mool M)
        {
            _db.Mools.Add(M);
            _db.SaveChanges();
            return M;
        }
        public int updateMool(Mool mool)
        {
            var m = _db.Mools.FirstOrDefault(x => x.Id == mool.Id);
            if (m == null)
            {
               return 0;
            }
             m.Name= mool.Name;
              m.Address= mool.Address;
            return _db.SaveChanges();
            
        }

        public int deleteMool(string id)
        {
            var m =_db.Mools.FirstOrDefault(x=> x.Id == id);

            _db.Mools.Remove(m);
            return _db.SaveChanges();
        }
    }
}
