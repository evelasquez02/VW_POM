﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using System.Data;

namespace VW_POM
{
    public partial class XtraPOM2 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraPOM2()
        {
            InitializeComponent();
        }

        private void XtraPOM2_BeforePrint(object sender, CancelEventArgs e)
        {
            //GroupField sortField = new GroupField("DATO");
            //sortField.SortOrder = XRColumnSortOrder.Ascending;
            //this.Detail.SortFields.Add(sortField);

            //GroupField sortField1 = new GroupField("TURNO");
            //sortField1.SortOrder = XRColumnSortOrder.Ascending;
            //this.Detail.SortFields.Add(sortField1);
        }

        private void XtraPOM2_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {

        }

        private void XtraPOM2_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {


        }
    }
}
