using System.Collections.Generic;

namespace MooolApp.Models.Repo
{
    public class ItemRepo : IItemRepo
    {

        private readonly DbMool _db;
        public ItemRepo(DbMool db)
        {
            db = db;
        }
       


        public List<Item> GETAll()
        {

            List<Item> it = _db.Items.ToList();
            if (it != null)
            {

                return it;
            }
            return null;
        }

        public Item insertItem( Item item)
        {
            _db.Items.Add(item);
            _db.SaveChanges();
            return item;
        }

        public int  updateItem(Item item)
        {
            var it = _db.Items.First(x => x.Id==item.Id);
            if (it != null)
            {
                it.price = item.price;
                it.Description = item.Description;
                it.Name = item.Name;

                return _db.SaveChanges();
            }
            return 0;
        }

        public int  DeleteItem(string id)
        {
            var item = _db.Items.SingleOrDefault(x => x.Id == id);
            _db.Items.Remove(item);

            return _db.SaveChanges();
        }

          public Item GetItem(string id)
        {
           var it =_db.Items.FirstOrDefault(x => x.Id==id);
            if(it== null)
            {
                return default(Item);
            }
            return it;
        }
    }
}
