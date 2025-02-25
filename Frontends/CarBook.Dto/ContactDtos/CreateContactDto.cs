using System.ComponentModel;

namespace CarBook.Dto.ContactDtos;

public class CreateContactDto
{
    [DisplayName("Adınız")]
    public string Name { get; set; }
    [DisplayName("E-Posta")]
    public string Email { get; set; }
    [DisplayName("Konu")]
    public string Subject { get; set; }
    [DisplayName("Mesaj")]
    public string Message { get; set; }
    [DisplayName("Gönderim Tarihi")]
    public DateTime SendDate { get; set; }
}
