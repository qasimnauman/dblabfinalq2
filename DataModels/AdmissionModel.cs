namespace DataModels
{
    public class AdmissionModel
    {
        public int adid { get; set; }
        public int did { get; set; }
        public int pid { get; set; }
        public DateOnly Adate { get; set; }
        public DateOnly DisDate { get; set; }
        public int Rno { get; set; }
    }
}
