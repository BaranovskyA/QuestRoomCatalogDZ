using QuestRoomCatalog.BusinessLayer.BusinessObjects;
using QuestRoomCatalog.DataLayer;
using QuestRoomCatalog.DataLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomCatalog.BusinessLayer.Helpers
{
    public class QuestRoomsHelper : ICrud<QuestsRoomsBO>
    {
        UnitOfWork Db { get; set; }

        public QuestRoomsHelper(UnitOfWork uow)
        {
            Db = uow;
        }

        public void Create(QuestsRoomsBO Bo)
        {
            if (Bo.Id == 0)
            {
                QuestsRooms questRooms = AutoMapper<QuestsRoomsBO, QuestsRooms>.Map(Bo);
                Db.QuestsRoomsUowRepository.Add(questRooms);
                Db.Save();
            }

        }
    }
}
