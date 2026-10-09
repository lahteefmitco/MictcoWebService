namespace MictcoWebService.Models
{
    public class SalesProducts
    {
        public int? psp_ir_id { get; set; }
        public int psp_qty { get; set; }
        public string psp_uniquecode { get; set; }
        public double psp_rate { get; set; }
        public double psp_realrate { get; set; }
        public double gross { get; set; }
        public double psp_disc_per { get; set; }
        public double psp_disc { get; set; }
        public double psp_real_disc { get; set; }
        public double net { get; set; }
        public double tax { get; set; }
        public double cgst { get; set; }
        public double sgst { get; set; }
        public double psp_total { get; set; }
        public double psp_profit { get; set; }
        public double psp_mrp { get; set; }
        public double psp_qty_multi_unit { get; set; }
        public string psp_unit_multi { get; set; }
        public double psp_srate_multiunit { get; set; }
        public string sp_narration { get; set; }
        public double kfc { get; set; }
        public double sp_prate { get; set; }
        public double realprate { get; set; }
        public string sp_cost { get; set; }
        public double sp_local_exp { get; set; }
        public double sp_lend_amount { get; set; }
        public string sp_narration1 { get; set; }
        public double sp_total { get; set; }
    }
}
