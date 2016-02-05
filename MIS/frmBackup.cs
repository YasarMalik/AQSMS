using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;



namespace MIS
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
            
        }

       
        private void btnBackup_Click(object sender, EventArgs e)
        {


            BackupDatabase("d:\\");
        }
        public static void BackupDatabase(string backUpFile)
        {
            ServerConnection con = new ServerConnection(@"YasarMalik-PC\SQLEXPRESS");

            
            Server server = new Server(con);
            Backup source = new Backup();
            source.Action = BackupActionType.Database;
            source.Database = "AQSMS";
            BackupDeviceItem destination = new BackupDeviceItem(backUpFile, DeviceType.File);
            source.Devices.Add(destination);
            source.SqlBackup(server);
            con.Disconnect();
        }
        /// <summary>
        /// Restore a whole database from a backup file.
        /// </summary>
        /// <remarks>
        /// The database must not be in use when backing up
        /// The folder holding the file must have appropriate permissions given
        /// </remarks>
        /// <param name="backUpFile">Full path to file to holding the backup</param>
        //public static void RestoreDatabase(string backUpFile)
        //{
        //    ServerConnection con = new ServerConnection(@"xxxxx\SQLEXPRESS");
        //    Server server = new Server(con);
        //    Restore destination = new Restore();
        //    destination.Action = RestoreActionType.Database;
        //    destination.Database = "MyDataBaseName";
        //    BackupDeviceItem source = new BackupDeviceItem(backUpFile, DeviceType.File);
        //    destination.Devices.Add(source);
        //    destination.ReplaceDatabase = true;
        //    destination.SqlRestore(server);
        //}

        
    }
}
