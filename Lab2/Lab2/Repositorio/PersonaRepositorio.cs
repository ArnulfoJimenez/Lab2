using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Repositorio
{
    public class PersonaRepositorio : IPersona
    {
        private AppDbContext app;

        public PersonaRepositorio(AppDbContext app)
        {
            this.app = app;
        }

    }
}
