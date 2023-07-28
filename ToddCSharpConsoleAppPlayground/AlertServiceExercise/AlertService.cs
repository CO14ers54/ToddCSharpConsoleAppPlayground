using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.AlertServiceExercise
{
    public interface IAlertDAO
    {
        public Guid AddAlert(DateTime time);
        public DateTime GetAlert(Guid id);
    }

    public  class AlertService
    {
        private readonly AlertDAO storage = new AlertDAO();
        private readonly IAlertDAO m_alertDAO;

        public AlertService(IAlertDAO alertDao) 
        { 
            m_alertDAO = alertDao;
        }
        
        public Guid RaiseAlert()
        {
            return m_alertDAO.AddAlert(DateTime.Now);
        }

        public DateTime GetAlertTime(Guid id)
        {
            return m_alertDAO.GetAlert(id);
        }
    }

    public class AlertDAO : IAlertDAO
    {
        private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

        public Guid AddAlert(DateTime time)
        {
            Guid id = Guid.NewGuid();
            this.alerts.Add(id, time);
            return id;
        }

        public DateTime GetAlert(Guid id)
        {
            return this.alerts[id];
        }
    }
}
