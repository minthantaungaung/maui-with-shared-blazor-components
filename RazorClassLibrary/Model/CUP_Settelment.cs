namespace RazorClassLibrary.Model
{
    public class CupSettlementDto
    {
        public string? InstitutionCode { get; set; }
        public string? IssuerAmountSign { get; set; }
        public string? IssuerAmount { get; set; }
        public string? AcquirerAmountSign { get; set; }
        public string? AcquirerAmount { get; set; }
        public string? NetAmountSign { get; set; }
        public string? NetAmount { get; set; }
        public string? IssuerFeeSign { get; set; }
        public string? IssuerFee { get; set; }
        public string? AcquirerFeeSign { get; set; }
        public string? AcquirerFee { get; set; }
        public string? NetFeeSign { get; set; }
        public string? NetFees { get; set; }
        public string? TotalNetAmountSign { get; set; }
        public string? TotalNetAmount { get; set; }
        public string? CurrencyCode { get; set; }
        public string? Currency { get; set; }
        public string? Status { get; set; }
        public string? TotalNoOfAcquirerTrans { get; set; }
        public string? TotalNoOfissuerTrans { get; set; }
        public string? BranchCode { get; set; }
        public string? FileName { get; set; }
        public string? FileDate { get; set; }
        public string? CurrencyStatus { get; set; }
        public double? GrandTotal { get; set; }
        public string? ResponseCode { get; set; }
        public string? ResponseMessage { get; set; }
        public string? BankName { get; set; }
        public string? NostroAccount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? TrnRefNo { get; set; }
        public string? BatchNo { get; set; }
    }
}
