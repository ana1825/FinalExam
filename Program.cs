using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballChempionship
{
    class Program
    {

        private static void addTeams()
        {
            String footballTeamName = "";

            Console.WriteLine("Enter team names or EXIT");
            using (var db = new FootballChampionshipDB())
            {
                int teamCounter = 0;
                while (true)
                {
                    footballTeamName = Console.ReadLine();
                    if (!footballTeamName.Equals("exit"))
                    {
                        db.footballTeams.Add(new FootballTeam()
                        {
                            teamName = footballTeamName,
                            score = 0
                        });
                        teamCounter++;
                    }

                    else if (footballTeamName.Equals("exit") && teamCounter < 5)
                    {
                        Console.WriteLine("Number of teams must be minimum 5");
                        footballTeamName = "";
                    }
                    else
                    {

                        break;
                    }

                }

                db.SaveChanges();


                Console.WriteLine("finished");

            }
        }
        private static int getMatchResult()
        {

            Console.WriteLine("Choose action:");
            String result = Console.ReadLine();

            switch (result)
            {

                case "1": return 3; break;
                case "2": return 0; break;
                case "3": return -1; break;
                default: return 10;

            }

        }
        private static void addResults()
        {
            using (var db = new FootballChampionshipDB())
            {
                Console.WriteLine("1-mogeba, 2-fre, 3-tsageba");
                for (int i = 0; i < db.footballTeams.Count(); i++)
                {
                    for (int j = i + 1; j < db.footballTeams.Count(); j++)
                    {
                        int aScore = 0;
                        Console.WriteLine(db.footballTeams.ToList().ElementAt(i).teamName + " " + db.footballTeams.ToList().ElementAt(j).teamName);
                        while ((aScore = getMatchResult()) == 10)
                        {
                            Console.WriteLine("Incorrect action  try again");
                        }


                        int bScore = 0;

                        switch (aScore)
                        {

                            case 0: bScore = 0; break;
                            case 3: bScore = -1; break;
                            case -1: bScore = 3; break;
                        }


                        db.championships.Add(new Championship()
                        {
                            teamAId = db.footballTeams.ToList().ElementAt(i).FootballTeamId,
                            teamBId = db.footballTeams.ToList().ElementAt(j).FootballTeamId,
                            scoreA = aScore,
                            scoreB = bScore
                        });

                        db.footballTeams.ToList().ElementAt(i).score += aScore;
                        db.footballTeams.ToList().ElementAt(j).score += bScore;

                    }
                }

                db.SaveChanges();


            }
        }
        private static void printResults()
        {
            using (var db = new FootballChampionshipDB())
            {

                foreach (var team in db.footballTeams.OrderByDescending(x => x.score).ThenBy(x => x.teamName))
                {
                    Console.WriteLine(team);
                }


            }

        }

        static void Main(string[] args)
        {

            addTeams();
            addResults();
            printResults();
        }
    }
}


