using System.ComponentModel.DataAnnotations;


public class Clientes{

    [Key]
    public int ClienteId { get; set; }

    [Required(ErrorMessage ="El nombre es requerido")]
    public string ? Nombre { get; set; }

     [Required(ErrorMessage ="El telefono es requerido")]
    public string ? Telefono { get; set; }

     [Required(ErrorMessage ="El celular es requerido")]
    public string ? Celular { get; set; }

     [Required(ErrorMessage ="El Rnc es requerido")]
    public string ? Rnc { get; set; }

     [Required(ErrorMessage ="El Email es requerido")]
    public string ? Email { get; set; }

     [Required(ErrorMessage =" La direccion es requerido")]
    public string ? Direccion { get; set; }
  

}