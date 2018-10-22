using HR2.Model.ViewModels;

namespace HR2.Service.Contracts
{
    public interface ISalesService
    {
        InvoiceDTO GetInvoiceBySaleOrderID(int id);
    }
}
