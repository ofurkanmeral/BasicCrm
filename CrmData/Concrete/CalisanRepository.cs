using CrmData.Abstract;
using CrmEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrmData.Concrete
{
    public class CalisanRepository : GenericRepository<calisan, DataContext>, ICalisan
    {
     
    }
}
