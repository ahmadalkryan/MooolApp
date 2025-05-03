namespace MooolApp.Models.Repo
{
    public interface IItemRepo
    {
        public List<Item> GETAll();
        public Item insertItem(Item item);
        public int updateItem(Item item);
        public int DeleteItem(string id);

        public Item GetItem(string id);
    }
}
