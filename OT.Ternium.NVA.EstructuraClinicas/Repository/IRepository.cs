using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OT.Ternium.NVA.EstructuraClinicas.Repository
{
    //The Generic Interface Repository for Performing Read/Add/Delete operations
    public interface IRepository<TEnt, in TPk> where TEnt : class
    {
        IEnumerable<TEnt> Get(object[] parameters);
        TEnt Get(TPk id);
        void Add(TEnt entity);
        void Remove(TEnt entity);
        IEnumerable<Models.General.Combo> GetCombo(object[] parameters);
        object GetComboMedico(object[] parameters);
        object GetComboEspecialidad(object[] parameters);
    }
}