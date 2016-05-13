using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Kapsalon.Service
{
    public partial class KapsalonService : ServiceBase
    {
        private Logger _logger = LogManager.GetCurrentClassLogger();
        public KapsalonService()
        {
            _logger.Info("Service starting");
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }

        /// <summary>
        /// Starts the service as console application when running interactively.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public void StartConsole(string[] args)
        {
            OnStart(args);
        }
        /// <summary>
        /// Stops the service as console application when running interactively.
        /// </summary>
        public void StopConsole()
        {
            OnStop();
        }
    }
}
