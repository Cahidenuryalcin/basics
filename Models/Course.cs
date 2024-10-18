namespace basics.Models // poje ismi + kalsör ismi
{
    public class Course
    {
        // prop ile obje oluşturulur
        public int Id { get; set; }

        public string? Title { get; set; }
        // Title'ın null olma ihtialine karşı ? eklenebilir ya da program.cs dosyasında nullable<disable> yaparak da uyarıların önğne geçilebilir.

        public string? Description { get; set; }

        public string? Image { get; set; }
    }
}