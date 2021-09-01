using CrmEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmData.Abstract
{
    public interface INotifyRepository:IRepository<notify>
    {
        List<notify> getCalisan();
    }
}
