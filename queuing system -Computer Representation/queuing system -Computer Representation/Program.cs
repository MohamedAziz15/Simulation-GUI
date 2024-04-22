using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queuing_system__Computer_Representation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());





        }
    }
    class Simulation
    {
        static int num_delays_required = 1000;
        static int Queue_size = 32000;
        static int next_event_type; //1 or 2
        static int num_custs_delayed;
        static int num_in_q;
        static int server_status;
        static double area_num_in_q;
        static double area_server_status;
        static double total_of_delays;
        static double mean_interarrival = 1;
        static double mean_service = 0.5;
        static double sim_time;
        static double time_last_event;

        static double[] time_arrival = new double[Queue_size];
        static double[] time_next_event = new double[3];
        static Random random = new Random(10000);

        static void Main1(string[] args)
        {
            initialize();
            while (num_custs_delayed < num_delays_required)
            {
                timing();

                //update statistical counters
                update_time_avg_stats();
                switch (next_event_type)
                {
                    case 1:
                        arrive();
                        break;
                    case 2:
                        depart();
                        break;
                }
            }
            report();
        }

        static void initialize()
        {
            sim_time = 0;
            server_status = 0;
            num_in_q = 0;
            time_last_event = 0;
            num_custs_delayed = 0;
            total_of_delays = 0;
            area_num_in_q = 0;
            area_server_status = 0;
            time_next_event[1] = sim_time + expon(mean_interarrival);
            time_next_event[2] = 1.0e+30; //10^30
        }
        static void timing()
        {
            if (time_next_event[1] < time_next_event[2])
                next_event_type = 1;//arrival
            else
                next_event_type = 2; //departure
            sim_time = time_next_event[next_event_type];
        }

        static void update_time_avg_stats()
        {
            double lag;
            //sim_time: clock, time of current event
            lag = sim_time - time_last_event;

            //area under Q(t)
            area_num_in_q += num_in_q * lag;

            //area under B(t)
            area_server_status += server_status * lag;

        }

        static void arrive()
        {

            double delay;
            time_next_event[1] = sim_time + expon(mean_interarrival);

            if (server_status == 1)
            {
                num_in_q++;
                time_arrival[num_in_q] = sim_time;
            }
            else
            {
                delay = 0;
                total_of_delays += delay;
                num_custs_delayed++;
                server_status = 1;
                time_next_event[2] = sim_time + expon(mean_service);
            }
        }

        static void depart()
        {
            double delay;
            if (num_in_q == 0)
            {
                server_status = 0;
                time_next_event[2] = 1.0e+30;
            }
            else
            {
                num_in_q--;
                delay = sim_time - time_arrival[1];
                total_of_delays += delay;

                num_custs_delayed++;
                time_next_event[2] = sim_time + expon(mean_service);

                for (int i = 1; i <= num_in_q; i++)
                {
                    time_arrival[1] = time_arrival[i + 1];
                }
            }
        }

        static void report()
        {

            Console.WriteLine("Total customer use this server: " + num_custs_delayed + "\n");
            Console.WriteLine("Average delay in queu in minutes d(n): " + total_of_delays / num_custs_delayed + "\n");
            Console.WriteLine("Average number in queue q(n): " + area_num_in_q / sim_time + "\n");
            Console.WriteLine("Server utilozation u(n): " + area_server_status / sim_time + "\n");



        }
        static double expon(double mean)
        {
            return -mean * Math.Log(random.NextDouble());
        }
    }

}
