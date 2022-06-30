using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaBlockChain.Controllers
{
    interface CRUDController<T>
    {
        void Create(T model);
        void Read();
        void Update(int id, T model);
        void Delete(int id);
    }
}
