namespace TrungTamTinHoc_BE.Models
{
    public class KhoaHoc
    {
        public string maKH { get; set; }
        public string tenKH { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public int rate { get; set; }
        public string luaTuoi { get; set; }//lứa tuổi
        public string pathImage { get; set; }
        public string Loai { get; set; }
        public string maGV { get; set; }
        public GiangVien? GiangVien { get; set; }
        public List<CTKhoaHoc>? CTKhoaHocs { get; set; }
    }
}
