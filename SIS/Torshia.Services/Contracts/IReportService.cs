﻿namespace Torshia.Services.Contracts
{
    using System.Collections.Generic;

    using Torshia.ViewModels.Reports;

    public interface IReportService
    {
        ReportDetailsViewModel GetReportById(int id);

        ICollection<ReportViewModel> GetReports();

        void ReportTask(int taskId, string reporter);
    }
}