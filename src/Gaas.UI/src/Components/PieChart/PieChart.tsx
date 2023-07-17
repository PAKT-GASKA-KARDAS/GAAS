import "./PieChart.scss";
import { PieChart as MuiPieChart } from "@mui/x-charts";

interface PieChartData {
  id: string;
  value: number;
  label: string;
}

interface PieChartProps {
  width: number;
  height: number;
  data: PieChartData[];
  colors: string[];
}

const PieChart = ({ width, height, data, colors }: PieChartProps) => {
  return (
    <MuiPieChart
      width={width}
      height={height}
      data={data}
      colors={colors}
      series={[
        {
          type: "pie",
          innerRadius: 30,
          outerRadius: 100,
          paddingAngle: 5,
          cornerRadius: 5,
          data: data,
        },
      ]}
    />
  );
};

export default PieChart;
