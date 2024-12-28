using to_do_list_api.DTO;
using to_do_list_api.Model;

namespace to_do_list_api.repo
{
    public interface todolist_rebo
    {
        public void add_task(string name, bool ischeck);
        public bool remove_task(string name);
        public List<Todolist_dto> get_all();
        public bool update(int id,string name, bool ischeck);

    }
}
