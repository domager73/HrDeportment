using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrDeportment
{
    public class PostStorage
    {
        private List<string> _posts;

        public PostStorage() 
        {
            _posts = new List<string>() { "Деректор", "Уборщица", "Сеньер", "Мидле", "Джун"};
        }

        List<string> GetPosts() => _posts;
    }
}
