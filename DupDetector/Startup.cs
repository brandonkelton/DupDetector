using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector
{
    public class Startup
    {
        public Startup()
        {
            Bootstrapper.ConfigureServices();
            ModelMapper.Initialize();

            var mainWindow = Bootstrapper.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
