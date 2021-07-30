using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _1._ADO.Net_con_MySQL
{
    class ManejadorArchivoXml : ManejadorArchivo
    {
        protected DataSet ds;
        public override System.Data.DataTable getTabla()
        {
            this.ds = new DataSet();
            this.ds.ReadXml("agenda.xml");
            return this.ds.Tables["contactos"];
        }
        public override void aplicaCambios()
        {
            this.ds.WriteXml("agenda.xml");
            this.ds.WriteXml("agendaconschemaxml", XmlWriteMode.WriteSchema);
        }
    }
}
