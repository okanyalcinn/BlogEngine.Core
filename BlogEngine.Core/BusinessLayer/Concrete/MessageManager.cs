using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(Message t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetList()
        {
            return _messageDal.GetListAll().OrderByDescending(x=> x.MessageDate).Take(5).ToList();
        }

        public List<Message> GetInBoxListByWriter(string p)
        {
            return _messageDal.GetListAll(x=> x.Receiver == p).OrderByDescending(x => x.MessageDate).Take(5).ToList();
        }

        public void Update(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
