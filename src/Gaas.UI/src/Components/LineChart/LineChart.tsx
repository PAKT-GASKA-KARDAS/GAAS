import "./LineChart.scss";
import { LineChart as MuiLineChart } from "@mui/x-charts";

interface LineChartProps {
  xAxisData: string[];
  seriesData: number[];
  width: number;
  height: number;
  colors: string[];
}

const LineChart = ({
  xAxisData,
  seriesData,
  width,
  height,
  colors,
}: LineChartProps) => {
  return (
    <MuiLineChart
      xAxis={[
        {
          scaleType: "point",
          data: xAxisData,
        },
      ]}
      series={[
        {
          type: "line",
          data: seriesData,
        },
      ]}
      width={width}
      height={height}
      colors={colors}
    />
  );
};

export default LineChart;
