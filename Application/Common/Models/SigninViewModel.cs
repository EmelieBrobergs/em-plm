using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models;

public record SigninViewModel
{
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}
