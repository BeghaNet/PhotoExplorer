//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a �t� g�n�r� par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apport�es � ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est r�g�n�r�.
// </auto-generated>
//------------------------------------------------------------------------------

using PhotoExplorer.Components.Models;
using System.Net.Http.Json;

namespace PhotoExplorer.Component;


public partial class PhotoList
{
    private List<Photo>? _photos;

    protected override async Task OnInitializedAsync()
    {
        using (var client = new HttpClient())
        {
            _photos = await client.GetFromJsonAsync<List<Photo>>("http://localhost:5233");
        }
    }
}