using ExamenIIIPac_DouglasReyes_.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace ExamenIIIPac_DouglasReyes_.Pages.Usuarios;

    partial class Usuarios
    {
        [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

        private IEnumerable<Usuario> usuariosLista { get; set; }

        protected override async Task OnInitializedAsync()
        {
            usuariosLista = await _usuarioServicio.GetLista();
        }

    }

