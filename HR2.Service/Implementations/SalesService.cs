using HR2.DAL.Contracts;
using HR2.Model;
using HR2.Model.ViewModels;
using HR2.Repository;
using HR2.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HR2.Service.Implementations
{
    public class SalesService : ISalesService
    {
        IUnitOfWork _unitOfWork;
        ISalesOrderHeaderRepository _salesOrderHeaderRepository;
        ISalesOrderDetailRepository _salesOrderDetailRepository;


        public SalesService(
            IUnitOfWork unitOfWork,
            ISalesOrderHeaderRepository salesOrderHeaderRepository,
            ISalesOrderDetailRepository salesOrderDetailRepository)
        {
            this._unitOfWork = unitOfWork;
            this._salesOrderHeaderRepository = salesOrderHeaderRepository;
            this._salesOrderDetailRepository = salesOrderDetailRepository;
        }

        #region SalesHeader

        public InvoiceDTO GetInvoiceBySaleOrderID(int id)
        {
            SalesOrderHeader objSalesOrderHeader = _salesOrderHeaderRepository.GetById(id);
            return CreateInvoiceDTO(objSalesOrderHeader);
        }

        private InvoiceDTO CreateInvoiceDTO(SalesOrderHeader salesOrder)
        {
            InvoiceDTO objInvoiceDTO = new InvoiceDTO();
            List<SalesOrderDetail> salesOrderDetails = _salesOrderDetailRepository.GetMany(x => x.SalesOrderID == salesOrder.SalesOrderID).ToList();
            List<ProductDTO> lstProduct = new List<ProductDTO>();
            objInvoiceDTO.CustomerID = salesOrder.CustomerID;
            objInvoiceDTO.SalesOrderNumber = salesOrder.SalesOrderNumber;
            objInvoiceDTO.PurchaseOrderNumber = salesOrder.PurchaseOrderNumber;
            objInvoiceDTO.Title = salesOrder.Customer.Title;
            objInvoiceDTO.FirstName = salesOrder.Customer.FirstName;
            objInvoiceDTO.MiddleName = salesOrder.Customer.MiddleName;
            objInvoiceDTO.LastName = salesOrder.Customer.LastName;
            objInvoiceDTO.OrderDate = salesOrder.OrderDate;
            objInvoiceDTO.DueDate = salesOrder.DueDate;
            objInvoiceDTO.ShipDate = salesOrder.ShipDate;
            objInvoiceDTO.SubTotal = decimal.Round(salesOrder.SubTotal, 2, MidpointRounding.AwayFromZero);
            objInvoiceDTO.TaxAmt = decimal.Round(salesOrder.TaxAmt, 2, MidpointRounding.AwayFromZero);
            objInvoiceDTO.Freight = decimal.Round(salesOrder.Freight, 2, MidpointRounding.AwayFromZero);
            objInvoiceDTO.TotalDue = decimal.Round(salesOrder.TotalDue, 2, MidpointRounding.AwayFromZero);
            objInvoiceDTO.products = lstProduct;
            return objInvoiceDTO;
        }

        #endregion SalesHeader

    }

    public class ProductDetails
    {
        public decimal totalPrice { get; set; }
        public Dictionary<Product, short> products { get; set; }
    }
}
