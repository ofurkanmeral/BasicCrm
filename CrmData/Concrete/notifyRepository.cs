using CrmData.Abstract;
using CrmEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrmData.Concrete
{
    public class notifyRepository : GenericRepository<notify, DataContext>, INotifyRepository
    {
        public List<notify> getCalisan()
        {
            using(var context=new DataContext())
            {
                return  context.notify
               .Include(x => x.calisan)
               .ThenInclude(x=>x.company)
                .ToList();
            }
        }
    }
}
