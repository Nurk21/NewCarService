using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Common
{
    public interface IIdentifiable
    {
        Guid Id { get; }
    }
}
