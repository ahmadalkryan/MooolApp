namespace MooolApp.Models.Repo
{
    public interface IMoolRepo
    {
        public List<Mool> GetAll();
        public Mool InsertMoll(Mool M);
        public int updateMool(Mool mool);
        public int deleteMool(string id);

        public Mool GetMool(string id);
    }
}
