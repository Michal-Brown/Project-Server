using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    public class Converters
    {
        public Converters()
        {

        }

        // Company Converters
        public DAL.Company CompanyConverter(DTO.Company dtoCompany)
        {
            DAL.Company dalCompany = new DAL.Company();
            dalCompany.ID = dtoCompany.ID;
            dalCompany.Name = dtoCompany.Name;
            return dalCompany;
        }
        public DTO.Company CompanyConverter(DAL.Company dalCompany)
        {
            DTO.Company dtoCompany = new DTO.Company();
            dtoCompany.ID = dalCompany.ID;
            dtoCompany.Name = dalCompany.Name;
            return dtoCompany;
        }
        public IEnumerable<DAL.Company> CompaniesConverter(List<DTO.Company> dtoCompanies)
        {
            foreach (DTO.Company company in dtoCompanies)
                yield return CompanyConverter(company);
        }
        public IEnumerable<DTO.Company> CompaniesConverter(List<DAL.Company> dalCompanies)
        {
            foreach (DAL.Company company in dalCompanies)
                yield return CompanyConverter(company);
        }

        // Customer Converters
        public DAL.Customer CustomerConverter(DTO.Customer dtoCustomer)
        {
            DAL.Customer dalCustomer = new DAL.Customer();
            dalCustomer.ID = dtoCustomer.ID;
            dalCustomer.FName = dtoCustomer.FName;
            dalCustomer.LName = dtoCustomer.LName;
            dalCustomer.Phone = dtoCustomer.Phone;
            dalCustomer.Address = dtoCustomer.Address;
            dalCustomer.City = dtoCustomer.City;
            return dalCustomer;
        }
        public DTO.Customer CustomerConverter(DAL.Customer dalCustomer)
        {
            DTO.Customer dtoCustomer = new DTO.Customer();
            dtoCustomer.ID = dalCustomer.ID;
            dtoCustomer.FName = dalCustomer.FName;
            dtoCustomer.LName = dalCustomer.LName;
            dtoCustomer.Phone = dalCustomer.Phone;
            dtoCustomer.Address = dalCustomer.Address;
            dtoCustomer.City = dalCustomer.City;
            return dtoCustomer;
        }
        public IEnumerable<DAL.Customer> CustomersConverter(List<DTO.Customer> dtoCustomers)
        {
            foreach (DTO.Customer customer in dtoCustomers)
                yield return CustomerConverter(customer);
        }
        public IEnumerable<DTO.Customer> CustomersConverter(List<DAL.Customer> dalCustomers)
        {
            foreach (DAL.Customer customer in dalCustomers)
                yield return CustomerConverter(customer);
        }

        // Fix Converters
        public DAL.Fix FixConverter(DTO.Fix dtoFix)
        {
            DAL.Fix dalFix = new DAL.Fix();
            dalFix.ID = dtoFix.ID;
            dalFix.CustomerID = dtoFix.CustomerID;
            dalFix.ProfessionalID = dtoFix.ProfessionalID;
            dalFix.ProductID = dtoFix.ProductID;
            dalFix.ProblemDetails = dtoFix.ProblemDetails;
            dalFix.FixDetails = dtoFix.FixDetails;
            dalFix.Note = dtoFix.Note;
            dalFix.Date = dtoFix.Date;
            dalFix.PaymentConfirmation = dtoFix.PaymentConfirmation;
            return dalFix;
        }
        public DTO.Fix FixConverter(DAL.Fix dalFix)
        {
            DTO.Fix dtoFix = new DTO.Fix();
            dtoFix.ID = dalFix.ID;
            dtoFix.CustomerID = dalFix.CustomerID;
            dtoFix.ProfessionalID = dalFix.ProfessionalID;
            dtoFix.ProductID = dalFix.ProductID;
            dtoFix.ProblemDetails = dalFix.ProblemDetails;
            dtoFix.FixDetails = dalFix.FixDetails;
            dtoFix.Note = dalFix.Note;
            dtoFix.Date = dalFix.Date;
            dtoFix.PaymentConfirmation = dalFix.PaymentConfirmation;
            return dtoFix;
        }
        public IEnumerable<DAL.Fix> FixesConverter(List<DTO.Fix> dtoFixes)
        {
            foreach (DTO.Fix fix in dtoFixes)
                yield return FixConverter(fix);
        }
        public IEnumerable<DTO.Fix> FixesConverter(List<DAL.Fix> dalFixes)
        {
            foreach (DAL.Fix fix in dalFixes)
                yield return FixConverter(fix);
        }

        // Product Converters
        public DAL.Product ProductConverter(DTO.Product dtoProduct)
        {
            DAL.Product dalProduct = new DAL.Product();
            dalProduct.ID = dtoProduct.ID;
            dalProduct.TypeID = dtoProduct.TypeID;
            dalProduct.CompanyID = dtoProduct.CompanyID;
            dalProduct.Model = dtoProduct.Model;
            return dalProduct;
        }
        public DTO.Product ProductConverter(DAL.Product dalProduct)
        {
            DTO.Product dtoProduct = new DTO.Product();
            dtoProduct.ID = dalProduct.ID;
            dtoProduct.TypeID = dalProduct.TypeID;
            dtoProduct.CompanyID = dalProduct.CompanyID;
            dtoProduct.Model = dalProduct.Model;
            return dtoProduct;
        }
        public IEnumerable<DAL.Product> ProductsConverter(List<DTO.Product> dtoProducts)
        {
            foreach (DTO.Product product in dtoProducts)
                yield return ProductConverter(product);
        }
        public IEnumerable<DTO.Product> ProductsConverter(List<DAL.Product> dalProducts)
        {
            foreach (DAL.Product product in dalProducts)
                yield return ProductConverter(product);
        }

        // Product Type Converters
        public DAL.ProductType ProductTypeConverter(DTO.ProductType dtoProductType)
        {
            DAL.ProductType dalProductType = new DAL.ProductType();
            dalProductType.ID = dtoProductType.ID;
            dalProductType.Name = dtoProductType.Name;
            return dalProductType;
        }
        public DTO.ProductType ProductTypeConverter(DAL.ProductType dalProductType)
        {
            DTO.ProductType dtoProductType = new DTO.ProductType();
            dtoProductType.ID = dalProductType.ID;
            dtoProductType.Name = dalProductType.Name;
            return dtoProductType;
        }
        public IEnumerable<DAL.ProductType> ProductTypesConverter(List<DTO.ProductType> dtoProductTypes)
        {
            foreach (DTO.ProductType productType in dtoProductTypes)
                yield return ProductTypeConverter(productType);
        }
        public IEnumerable<DTO.ProductType> ProductTypesConverter(List<DAL.ProductType> dalProductTypes)
        {
            foreach (DAL.ProductType productType in dalProductTypes)
                yield return ProductTypeConverter(productType);
        }

        // Profession Converters
        public DAL.Profession ProfessionConverter(DTO.Profession dtoProfession)
        {
            DAL.Profession dalProfession = new DAL.Profession();
            dalProfession.ID = dtoProfession.ID;
            dalProfession.Name = dtoProfession.Name;
            return dalProfession;
        }
        public DTO.Profession ProfessionConverter(DAL.Profession dalProfession)
        {
            DTO.Profession dtoProfession = new DTO.Profession();
            dtoProfession.ID = dalProfession.ID;
            dtoProfession.Name = dalProfession.Name;
            return dtoProfession;
        }
        public IEnumerable<DAL.Profession> ProfessionsConverter(List<DTO.Profession> dtoProfession)
        {
            foreach (DTO.Profession profession in dtoProfession)
                yield return ProfessionConverter(profession);
        }
        public IEnumerable<DTO.Profession> ProfessionsConverter(List<DAL.Profession> dalProfession)
        {
            foreach (DAL.Profession profession in dalProfession)
                yield return ProfessionConverter(profession);
        }

        // Professional Converters
        public DAL.Professional ProfessionalConverter(DTO.Professional dtoProfessional)
        {
            DAL.Professional dalProfessional = new DAL.Professional();
            dalProfessional.ID = dtoProfessional.ID;
            dalProfessional.FName = dtoProfessional.FName;
            dalProfessional.LName = dtoProfessional.LName;
            dalProfessional.Phone = dtoProfessional.Phone;
            dalProfessional.ProfessionID = dtoProfessional.ProfessionID;
            dalProfessional.IsExpert = dtoProfessional.IsExpert;
            dalProfessional.CompanyID = dtoProfessional.CompanyID;
            dalProfessional.Specialty = dtoProfessional.Specialty;
            dalProfessional.VisitsArea = dtoProfessional.VisitsArea;
            dalProfessional.VisitPrice = dtoProfessional.VisitPrice;
            return dalProfessional;
        }
        public DTO.Professional ProfessionalConverter(DAL.Professional dalProfessional)
        {
            DTO.Professional dtoProfessional = new DTO.Professional();
            dtoProfessional.ID = dalProfessional.ID;
            dtoProfessional.FName = dalProfessional.FName;
            dtoProfessional.LName = dalProfessional.LName;
            dtoProfessional.Phone = dalProfessional.Phone;
            dtoProfessional.ProfessionID = dalProfessional.ProfessionID;
            dtoProfessional.IsExpert = dalProfessional.IsExpert;
            dtoProfessional.CompanyID = dalProfessional.CompanyID;
            dtoProfessional.Specialty = dalProfessional.Specialty;
            dtoProfessional.VisitsArea = dalProfessional.VisitsArea;
            dtoProfessional.VisitPrice = dalProfessional.VisitPrice;
            return dtoProfessional;
        }
        public IEnumerable<DAL.Professional> ProfessionalsConverter(List<DTO.Professional> dtoProfessional)
        {
            foreach (DTO.Professional professional in dtoProfessional)
                yield return ProfessionalConverter(professional);
        }
        public IEnumerable<DTO.Professional> ProfessionalsConverter(List<DAL.Professional> dalProfessional)
        {
            foreach (DAL.Professional professional in dalProfessional)
                yield return ProfessionalConverter(professional);
        }
    }
}
