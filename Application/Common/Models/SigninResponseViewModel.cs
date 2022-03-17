using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models;

public record SigninResponseViewModel
{
    public string AccessToken { get; set; } = null!;
    public UserViewModel User { get; set; } = null!;

}
