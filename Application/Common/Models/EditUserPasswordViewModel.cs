using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models;

public class EditUserPasswordViewModel
{
    public string OldPass { get; set; } = null!;
    public string NewPass { get; set; } = null!;
}
