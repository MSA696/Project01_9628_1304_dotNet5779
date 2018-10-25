using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface Idal
    {
        Tester addTester();
        void deleteTester();
        Tester setTester();

        Trainee addTrainee();
        void deleteTrainee();
        Trainee setTrainee();

        Test addTest();
        Test setTest();

        List<Tester> getTesters();
        List<Trainee> getTrainees();
        List<Test> getTests();
    }
}
