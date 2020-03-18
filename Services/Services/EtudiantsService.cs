using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class EtudiantsService
    {
        public biblioEntities _context { get; set; }
        public EtudiantsService()
        {
            _context = new biblioEntities();
        }
        public void AddEtudiant(eleves E)
        {
            _context.eleves.Add(E);
            _context.SaveChanges();
        }
        public bool EtudiantExiste(string code)
        {
            return _context.eleves.Any(a => a.codeElev == code);
        }
    }
}
