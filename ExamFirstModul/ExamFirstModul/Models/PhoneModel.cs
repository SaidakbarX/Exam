using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFirstModul.Models;


public class PhoneModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public double Price { get; set; }
    public string Color { get; set; }
}
