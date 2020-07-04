Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listorder()
        average()
        category()
        project()
    End Sub

    Private Sub listorder()


        Guna2DataGridView1.Rows.Add(7)
        Guna2DataGridView1.Rows(0).Cells(0).Value = Image.FromFile("ic\\theatre_mask_60px.png")
        Guna2DataGridView1.Rows(0).Cells(1).Value = "Entertaiment"
        Guna2DataGridView1.Rows(0).Cells(2).Value = "80.218"

        Guna2DataGridView1.Rows(1).Cells(0).Value = Image.FromFile("ic\\medical_bag_60px.png")
        Guna2DataGridView1.Rows(1).Cells(1).Value = "Medical"
        Guna2DataGridView1.Rows(1).Cells(2).Value = "42.009"

        Guna2DataGridView1.Rows(2).Cells(0).Value = Image.FromFile("ic\\open_box_60px.png")
        Guna2DataGridView1.Rows(2).Cells(1).Value = "Postrage"
        Guna2DataGridView1.Rows(2).Cells(2).Value = "20.009"


        Guna2DataGridView1.Rows(3).Cells(0).Value = Image.FromFile("ic\\movie_ticket_60px.png")
        Guna2DataGridView1.Rows(3).Cells(1).Value = "Ticketing"
        Guna2DataGridView1.Rows(3).Cells(2).Value = "8.919"

        Guna2DataGridView1.Rows(4).Cells(0).Value = Image.FromFile("ic\\airplane_take_off_60px.png")
        Guna2DataGridView1.Rows(4).Cells(1).Value = "Traveling"
        Guna2DataGridView1.Rows(4).Cells(2).Value = "7.302"

        Guna2DataGridView1.Rows(5).Cells(0).Value = Image.FromFile("ic\\maintenance_60px.png")
        Guna2DataGridView1.Rows(5).Cells(1).Value = "Utilities"
        Guna2DataGridView1.Rows(5).Cells(2).Value = "3.201"

        Guna2DataGridView1.Rows(6).Cells(0).Value = Image.FromFile("ic\\car_60px.png")
        Guna2DataGridView1.Rows(6).Cells(1).Value = "Vehicle"
        Guna2DataGridView1.Rows(6).Cells(2).Value = "45.019"


        Guna2DataGridView1.Rows(7).Cells(0).Value = Image.FromFile("ic\\gift_60px.png")
        Guna2DataGridView1.Rows(7).Cells(1).Value = "Gift"
        Guna2DataGridView1.Rows(7).Cells(2).Value = "6.009"
    End Sub


    Private Sub average()
        CartesianChart1.Series = New SeriesCollection From {
               New LineSeries With {
                    .Values = New ChartValues(Of ObservablePoint) From {
                        New ObservablePoint(0, 10),
                        New ObservablePoint(4, 7),
                        New ObservablePoint(5, 3),
                        New ObservablePoint(7, 6),
                        New ObservablePoint(10, 8)
                    },
                    .PointGeometrySize = 10
                },
                New LineSeries With {
                    .Values = New ChartValues(Of ObservablePoint) From {
                        New ObservablePoint(0, 2),
                        New ObservablePoint(2, 5),
                        New ObservablePoint(3, 6),
                        New ObservablePoint(6, 8),
                        New ObservablePoint(10, 5)
                    },
                    .PointGeometrySize = 15
                },
                New LineSeries With {
                    .Values = New ChartValues(Of ObservablePoint) From {
                        New ObservablePoint(0, 4),
                        New ObservablePoint(5, 5),
                        New ObservablePoint(7, 7),
                        New ObservablePoint(9, 10),
                        New ObservablePoint(10, 9)
                    },
                    .PointGeometrySize = 15
                }
                }
    End Sub

    Private Sub category()
        Dim labelPoint As Func(Of ChartPoint, String) = Function(chartPoint) String.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation)
        PieChart1.Series = New SeriesCollection From {
            New PieSeries With {
                .Title = "Maria",
                .Values = New ChartValues(Of Double) From {
                    3
                },
                .PushOut = 15,
                .DataLabels = True,
                .LabelPoint = labelPoint
            },
            New PieSeries With {
                .Title = "Charles",
                .Values = New ChartValues(Of Double) From {
                    4
                },
                .DataLabels = True,
                .LabelPoint = labelPoint
            },
            New PieSeries With {
                .Title = "Frida",
                .Values = New ChartValues(Of Double) From {
                    6
                },
                .DataLabels = True,
                .LabelPoint = labelPoint
            },
            New PieSeries With {
                .Title = "Frederic",
                .Values = New ChartValues(Of Double) From {
                    2
                },
                .DataLabels = True,
                .LabelPoint = labelPoint
            }
        }
        PieChart1.LegendLocation = LegendLocation.Bottom
    End Sub

    Private Sub project()
        CartesianChart2.Series = New SeriesCollection From {
            New RowSeries With {
                .Title = "2015",
                .Values = New ChartValues(Of Double) From {
                    10,
                    50,
                    39,
                    50
                }
            }
        }
        CartesianChart2.Series.Add(New RowSeries With {
            .Title = "2016",
            .Values = New ChartValues(Of Double) From {
                11,
                56,
                42
            }
        })
        CartesianChart2.Series(1).Values.Add(48.0R)
        CartesianChart2.AxisY.Add(New Axis With {
            .Labels = {"Maria", "Susan", "Charles", "Frida"}
        })
        CartesianChart2.AxisX.Add(New Axis With {
            .LabelFormatter = Function(value) value.ToString("N")
        })
        Dim tooltip = New DefaultTooltip With {
            .SelectionMode = TooltipSelectionMode.SharedYValues
        }
        CartesianChart2.DataTooltip = tooltip
    End Sub

End Class
