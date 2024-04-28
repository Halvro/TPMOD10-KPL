using Microsoft.AspNetCore.Mvc;
using TPMOD10;


namespace TPMOD10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa(" Haikal Alfaro", "1302220098"),
        new Mahasiswa(" Naufal Ajhar El Hafizh", "1302223040"),
        new Mahasiswa(" M Galang Pradwita", "1302223015"),
        new Mahasiswa(" Najwa Aulia Zahra", "1302220024")
    };
        [HttpGet]




        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMahasiswa.RemoveAt(id);
        }
    }

}
