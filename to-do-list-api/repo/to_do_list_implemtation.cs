using to_do_list_api.Data;
using to_do_list_api.DTO;
using to_do_list_api.Migrations;
using to_do_list_api.Model;

namespace to_do_list_api.repo
{
    public class to_do_list_imp : todolist_rebo
    {
        private readonly AppDbContext context;
        public to_do_list_imp(AppDbContext _context)
        {
            context= _context;
        }
        public void add_task(string name, bool ischeck)
        {
            var x = new To_do_list
            {
                Name = name,
                IsComplete = ischeck,
            };
            context.to_Do_Lists.Add(x);
            context.SaveChanges();
        }

        public List<Todolist_dto> get_all()
        {
            var x = context.to_Do_Lists.Select(z=>new Todolist_dto
            {
                Name=z.Name,
                IsComplete=z.IsComplete,
            }).ToList();
            return x;
            
        }

        public bool remove_task(string name)
        {
            var x = context.to_Do_Lists.FirstOrDefault(x=>x.Name == name);
            if(x != null)
            {
                context.to_Do_Lists.Remove(x);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool update(int id,string name, bool ischeck)
        {
            var x = context.to_Do_Lists.FirstOrDefault(x => x.Id == id);
            if (x != null)
            {
                x.Name = name;
                x.IsComplete=ischeck;
                context.to_Do_Lists.Update(x);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
