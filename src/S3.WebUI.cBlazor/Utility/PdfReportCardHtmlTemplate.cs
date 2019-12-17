using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using S3.WebUI.cBlazor.Models;

namespace S3.WebUI.cBlazor.Utility
{
    public static class PdfReportCardHtmlTemplate
    {
        public static string GetHTMLString(ClassReport classReport, Class selectedClass, int session, string[] classSubjects)
        {
            var sb = new StringBuilder();

            sb.Append($@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div id='all-report-cards'>");

            foreach (var studentReport in classReport.StudentReports)
            {
                sb.Append($@"
                                    <div class='report-card'>
                                        <table align='center'> ");

                sb.Append($@"
                                            <tr>
                                                <td>
                                                    <h3 class='py-2'>{studentReport.StudentName}</h3>
                                                    <p>Class: {selectedClass.Name}</p>
                                                    <p>Session: {session}</p>
                                                </td>
                                            </tr>");

                sb.Append($@"
                                             <tr>
                                                <td>
                                                    <table>
                                                        <tr>
                                                            <th>First Term</th>
                                                            <th>Second Term</th>
                                                            <th>Third Term</th>
                                                        </tr>

                                                        <tr>
                                                        <td>");

                var firstTermReport = studentReport.TermReports.FirstOrDefault(x => x.Term == Term.FirstTerm);
                var firstTermStat = classReport.ScoresStat.TermStats.FirstOrDefault(x => x.Term == Term.FirstTerm);

                sb.Append($@"
                                                            <table class='report-card-data'>
                                                                <colgroup>
                                                                    <col class='column-width-subject' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                </colgroup>
                                                                <tr class='vertical-align'>
                                                                    <th>Subject</th>
                                                                    <th>C.A</th>
                                                                    <th>1st Exam</th>
                                                                    <th>2nd Exam</th>
                                                                    <th>Homework</th>
                                                                    <th>Class Acts</th>
                                                                    <th>Total</th>
                                                                    <th>Class Min</th>
                                                                    <th>Class Max</th>
                                                                    <th>Class Ave</th>
                                                                    <th>Grade</th>
                                                                </tr>");

                foreach (var subject in classSubjects)
                {
                    var subjectReport = firstTermReport?.SubjectReports.FirstOrDefault(x => x.Subject == subject);
                    var subjectStat = firstTermStat?.Stats.FirstOrDefault(x => x.Subject == subject);

                    sb.Append($@"
                                                                <tr class='report-card-data'>
                                                                    <td>{subject}</td>
                                                                    <td>{subjectReport?.CAScore}</td>
                                                                    <td>{subjectReport?.FirstExamScore}</td>
                                                                    <td>{subjectReport?.SecondExamScore}</td>
                                                                    <td>{subjectReport?.HomeworkScore}</td>
                                                                    <td>{subjectReport?.ClassActivitiesScore}</td>
                                                                    <td>{subjectReport?.WeightedScore}</td>
                                                                    <td>{subjectStat?.ClassMinScore}</td>
                                                                    <td>{subjectStat?.ClassMaxScore}</td>
                                                                    <td>{subjectStat?.ClassAverageScore}</td>
                                                                    <td>{subjectReport?.Grade}</td>
                                                                </tr>");
                }

                sb.Append($@"
                                                            </table>
                                                        </td>
                                                    
                                                    <td>");

                var secondTermReport = studentReport.TermReports.FirstOrDefault(x => x.Term == Term.SecondTerm);
                var secondTermStat = classReport.ScoresStat.TermStats.FirstOrDefault(x => x.Term == Term.SecondTerm);

                sb.Append($@"
                                                            <table class='report-card-data'>
                                                                <colgroup>
                                                                    <col class='column-width-subject' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                </colgroup>
                                                                <tr class='vertical-align'>
                                                                    <th>Subject</th>
                                                                    <th>C.A</th>
                                                                    <th>1st Exam</th>
                                                                    <th>2nd Exam</th>
                                                                    <th>Homework</th>
                                                                    <th>Class Acts</th>
                                                                    <th>Total</th>
                                                                    <th>Class Min</th>
                                                                    <th>Class Max</th>
                                                                    <th>Class Ave</th>
                                                                    <th>Grade</th>
                                                                </tr>");

                foreach (var subject in classSubjects)
                {
                    var subjectReport = secondTermReport?.SubjectReports.FirstOrDefault(x => x.Subject == subject);
                    var subjectStat = secondTermStat?.Stats.FirstOrDefault(x => x.Subject == subject);

                    sb.Append($@"
                                                                <tr class='report-card-data'>
                                                                    <td>{subject}</td>
                                                                    <td>{subjectReport?.CAScore}</td>
                                                                    <td>{subjectReport?.FirstExamScore}</td>
                                                                    <td>{subjectReport?.SecondExamScore}</td>
                                                                    <td>{subjectReport?.HomeworkScore}</td>
                                                                    <td>{subjectReport?.ClassActivitiesScore}</td>
                                                                    <td>{subjectReport?.WeightedScore}</td>
                                                                    <td>{subjectStat?.ClassMinScore}</td>
                                                                    <td>{subjectStat?.ClassMaxScore}</td>
                                                                    <td>{subjectStat?.ClassAverageScore}</td>
                                                                    <td>{subjectReport?.Grade}</td>
                                                                </tr>");
                }

                sb.Append($@"
                                                            </table>
                                                        </td>
                                                    
                                                    <td>");


                var thirdTermReport = studentReport.TermReports.FirstOrDefault(x => x.Term == Term.ThirdTerm);
                var thirdTermStat = classReport.ScoresStat.TermStats.FirstOrDefault(x => x.Term == Term.ThirdTerm);

                sb.Append($@"
                                                            <table class='report-card-data'>
                                                                <colgroup>
                                                                    <col class='column-width-subject' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                    <col class='column-width' />
                                                                </colgroup>
                                                                <tr class='vertical-align'>
                                                                    <th>Subject</th>
                                                                    <th>C.A</th>
                                                                    <th>1st Exam</th>
                                                                    <th>2nd Exam</th>
                                                                    <th>Homework</th>
                                                                    <th>Class Acts</th>
                                                                    <th>Total</th>
                                                                    <th>Class Min</th>
                                                                    <th>Class Max</th>
                                                                    <th>Class Ave</th>
                                                                    <th>Grade</th>
                                                                </tr>");

                foreach (var subject in classSubjects)
                {
                    var subjectReport = thirdTermReport?.SubjectReports.FirstOrDefault(x => x.Subject == subject);
                    var subjectStat = thirdTermStat?.Stats.FirstOrDefault(x => x.Subject == subject);

                    sb.Append($@"
                                                                <tr class='report-card-data'>
                                                                    <td>{subject}</td>
                                                                    <td>{subjectReport?.CAScore}</td>
                                                                    <td>{subjectReport?.FirstExamScore}</td>
                                                                    <td>{subjectReport?.SecondExamScore}</td>
                                                                    <td>{subjectReport?.HomeworkScore}</td>
                                                                    <td>{subjectReport?.ClassActivitiesScore}</td>
                                                                    <td>{subjectReport?.WeightedScore}</td>
                                                                    <td>{subjectStat?.ClassMinScore}</td>
                                                                    <td>{subjectStat?.ClassMaxScore}</td>
                                                                    <td>{subjectStat?.ClassAverageScore}</td>
                                                                    <td>{subjectReport?.Grade}</td>
                                                                </tr>");
                }

                sb.Append($@"
                                        </table>
                                    </td> 
                                </tr>
                            </table>
                        </td>
                    </tr>");
            }

            sb.Append(@"
                                        </table>
                                    </div>
                                    <br />
                                </div>
                            </body>
                        </html>");



            return sb.ToString();
        }
    }
}
