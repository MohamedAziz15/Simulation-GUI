using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queuing_system__Computer_Representation
{
    public partial class Form1 : Form
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



        public Form1()
        {
            InitializeComponent();
            SimulationTimeBTN.Text = "0";
            ServerStateBTN.Text = "0";
            NumInQueueBTN.Text = "0";
            TimeLastEventBTN.Text = "0";
            NumDelayedBTN.Text = "0";
            TotalDelayBTN.Text = "0";
            AreaUnderQtBTN.Text = "0";
            AreaUnderBtBTN.Text = "0";
            ClockBTN.Text = "0";
            ArrivalBTN.Text = "0";
            DepartureBTN.Text = "0";



        }

        private void SimulateBTN_Click(object sender, EventArgs e)
        {
            initialize();
            
            while (num_custs_delayed < num_delays_required)
            {
                timing();

                //update statistical counters
                update_time_avg_stats();
                AreaUnderQtBTN.Text = area_num_in_q.ToString();
                AreaUnderBtBTN.Text = area_server_status.ToString();


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


        void initialize()
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
            //ArrivalBTN.Text = time_next_event[1].ToString();
            time_next_event[2] = 1.0e+30; //10^30
            //DepartureBTN.Text= time_next_event[2].ToString();
        }

        void timing()
        {
            if (time_next_event[1] < time_next_event[2])
                next_event_type = 1;//arrival
            else
                next_event_type = 2; //departure
            sim_time = time_next_event[next_event_type];
            SimulationTimeBTN.Text = sim_time.ToString();
            ClockBTN.Text = sim_time.ToString();
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

        void arrive()
        {

            double delay;
            time_next_event[1] = sim_time + expon(mean_interarrival);

            if (server_status == 1)
            {
                ClockBTN.Text = sim_time.ToString();
                ServerStateBTN.Text = server_status.ToString();
                num_in_q++;
                NumInQueueBTN.Text = num_in_q.ToString();
                time_arrival[num_in_q] = sim_time;

            }
            else
            {
                delay = 0;
                total_of_delays += delay;
                TotalDelayBTN.Text = total_of_delays.ToString();
                num_custs_delayed++;
                NumDelayedBTN.Text = num_custs_delayed.ToString();
                server_status = 1;
                ServerStateBTN.Text = server_status.ToString();
                time_next_event[2] = sim_time + expon(mean_service);

            }
        }

        void depart()
        {
            double delay;
            if (num_in_q == 0)
            {
                server_status = 0;
                ServerStateBTN.Text = server_status.ToString();
                time_next_event[2] = 1.0e+30;
                DepartureBTN.Text = time_next_event[2].ToString();
            }
            else
            {
                num_in_q--;
                NumInQueueBTN.Text = num_in_q.ToString();
                delay = sim_time - time_arrival[1];
                total_of_delays += delay;
                TotalDelayBTN.Text = total_of_delays.ToString();

                num_custs_delayed++;
                NumDelayedBTN.Text = num_custs_delayed.ToString();
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

        private void ReportBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total customer use this server: " + num_custs_delayed + "\n"+ "Average delay in queu in minutes d(n): " + total_of_delays / num_custs_delayed + "\n"+ "Average number in queue q(n): " + area_num_in_q / sim_time + "\n" + "Server utilozation u(n): " + area_server_status / sim_time + "\n");
            //MessageBox.Show("Average delay in queu in minutes d(n): " + total_of_delays / num_custs_delayed + "\n");
            //MessageBox.Show("Average number in queue q(n): " + area_num_in_q / sim_time + "\n");
            //MessageBox.Show("Server utilozation u(n): " + area_server_status / sim_time + "\n");

        }
    }
}
