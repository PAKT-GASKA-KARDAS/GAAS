import "./BarChart.scss";
import { BarChart as MuiBarChart } from "@mui/x-charts/BarChart";

interface BarChartProps {
  xAxisData: string[];
  seriesData: number[];
  width: number;
  height: number;
  color: string;
}

const BarChart = ({
  xAxisData,
  seriesData,
  width,
  height,
  color,
}: BarChartProps) => {
  return (
    <MuiBarChart
      className="bar-chart"
      xAxis={[
        {
          scaleType: "band",
          data: xAxisData,
        },
      ]}
      series={[
        {
          type: "bar",
          data: seriesData,
        },
      ]}
      width={width}
      height={height}
      colors={[color]}
    />
  );
};

export default BarChart;
