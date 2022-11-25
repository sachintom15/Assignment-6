using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Assignment_6.BAL
{
    public class desgBal
    {


        DAL.desgDal objdal = new DAL.desgDal();



        private int _pid;
        private string _desg;
        private int _desgid;


        public int DesgId
        {
            get
            {
                return _desgid;
            }
            set
            {
                _desgid = value;
            }
        }
        public int DepId
        {
            get
            {
                return _pid;
            }
            set
            {
                _pid = value;
            }
        }
        public string Desgination
        {
            get
            {
                return _desg;
            }
            set
            {
                _desg = value;
            }
        }
        public DataTable getdeprt()
        {
            return objdal.Getdeprt(this);
        }

        public int insertDesig()
        {
            return objdal.InsertDesig(this);
        }
        public DataTable viewdesign()
        {
            return objdal.desigview(this);
        }

        public int Desigupdate()
        {
            return objdal.desgUpdate(this);
        }

        public int deletedesig()
        {
            return objdal.Deletedesig(this);
        }

       
    }
}