using Classes_Metier;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;

namespace Campagne_de_validation_des_fiches_de_frais
{
    public class Service_de_Validation : System.ServiceProcess.ServiceBase
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        Timer timer;
        DataAccess da;
        public Service_de_Validation()
        {
            InitializeComponent();
        }

        //static void Main()
        //{
        //    System.ServiceProcess.ServiceBase[] ServicesToRun;
        //    ServicesToRun = new System.ServiceProcess.ServiceBase[] { new Service_de_Validation() };

        //    System.ServiceProcess.ServiceBase.Run(ServicesToRun);
        //}

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // Service_de_Validation
            // 
            components = new System.ComponentModel.Container();
            this.ServiceName = "Validation des fiches de frais";
            da = new DataAccess();
            EventLog.WriteEntry(da.ConnexionDB());
        }

        /// <summary>
        /// Clean up any resources that are being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Set things in motion so your service can do its work.
        /// </summary>
        protected override void OnStart(string[] args)
        {
            timer = new Timer();
            // 1000 = 1 Seconde
            this.timer.Interval = 60000;
            this.timer.Elapsed += new ElapsedEventHandler(this.timer_tick);
            this.timer.Enabled = true;
        }

        private void timer_tick(object sender, ElapsedEventArgs e)
        {
            if (DateManagement.entre(1, 10, DateTime.Now) == true)
            {
                EventLog.WriteEntry("Nous sommes le : " + DateTime.Now.Day + ". Les fiches de frais sont cloturées et en cours de traitement");
                da.ChangerEtat("CR", "CL");
            }
            else
            {
                if (DateManagement.entre(20, 31, DateTime.Now) == true)
                {
                    da.ChangerEtat("VA", "RB");
                    EventLog.WriteEntry("Nous sommes le : " + DateTime.Now.Day + ". Les fiches de frais sont Remboursées");
                }
                else
                {
                    EventLog.WriteEntry("Nous sommes le : " + DateTime.Now.Day + ". Rien ne se passe");
                }
            }
            EventLog.WriteEntry("Et la fonction aurait dû s'executer.");
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("Le service est arrêté");
            timer.Stop();
            timer = null;
        }
    }
}
