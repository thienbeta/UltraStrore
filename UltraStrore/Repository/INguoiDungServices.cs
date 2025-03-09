<<<<<<< HEAD
﻿using UltraStrore.Models.CreateModels;
=======
﻿using UltraStrore.Data;
using UltraStrore.Helper;
>>>>>>> 5436636fad539b2105ec948157f758fe5628a2d6
using UltraStrore.Models.EditModels;
using UltraStrore.Models.ViewModels;

namespace UltraStrore.Repository
{
    public interface INguoiDungServices
    {
<<<<<<< HEAD
        Task<List<NguoiDungView>> GetNguoiDungList(string? searchTerm);
        Task<NguoiDungView> GetNguoiDungById(string id);
        Task<NguoiDungView> CreateNguoiDung(NguoiDungCreate model);
        Task<NguoiDungView> UpdateNguoiDung(NguoiDungEdit model);
        Task<bool> DeleteNguoiDung(string id);
=======
>>>>>>> 5436636fad539b2105ec948157f758fe5628a2d6
    }
}
