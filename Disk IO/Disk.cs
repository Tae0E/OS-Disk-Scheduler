using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disk_IO
{
    class Disk
    {
        Queue<int> DiskQueue;


        public Disk()
        {
            this.DiskQueue = new Queue<int>();

        }

        public void EnqueueDiskQ(string args)
        {
            foreach (string tmp in args.Split(','))
            {
                this.DiskQueue.Enqueue(int.Parse(tmp));
            }
        }

        public void Clean()
        {
            this.DiskQueue.Clear();
            Tracer.counter = 0;
        }

        public List<Tracer> SchedulingWithFCFS(int intialPoint)//초기 위치 받아옴
        {
            List<Tracer> tr = new List<Tracer>();
            int acc = 0;
            int currentCur = intialPoint; //초기 위치로 현재위치 초기화
            int movement = 0; //초기니깐 이동거리 0

            double time=0;            //전체실행시간
            double m=0.3;              //디스크 드라이브에 따른 상수
            double rotation=8.3;    //평균회전지연시간
            tr.Add(new Tracer(currentCur, 0, 0,0)); //초기 위치랑 이동거리(0), 이동시간(0) 리스트에 추가 

            while (this.DiskQueue.Count > 0)
            {
                int nextCur = this.DiskQueue.Dequeue(); //젤 뒤에꺼 큐에서 delete == 그다음 위치
                movement = nextCur - currentCur; // 그 다음 위치 - 현재 위치
                acc = acc + Math.Abs(movement); //이동한 시간
                currentCur = nextCur; //다음위치로 이동
                time=time+m*(double)Math.Abs(movement)+rotation;    //전체실행시간
                tr.Add(new Tracer(currentCur, movement, acc, time)); //현재 위치랑 이동거리, 이동시간 리스트에 추가
            }
            this.Clean();
            return tr;
        }

        public List<Tracer> SchedulingWithSSTF(int intialPoint)//초기 위치 받아옴
        {
            List<Tracer> tr = new List<Tracer>();
            List<int> Disk_JOB = new List<int>();
            int acc = 0;
            int currentCur = intialPoint; //초기 위치로 현재위치 초기화
            int movement = 0; //초기니깐 이동거리 0

            
            double time=0;            //전체실행시간
            double m=0.3;              //디스크 드라이브에 따른 상수
            double rotation=8.3;    //평균회전지연시간

            int shortest_distance = 0; //가장 짧은 거리 구하기위해서
            int shortest_index; //가장 짧은 곳 List index
            int shortest_pos; //가장 짧은 곳

            Disk_JOB = this.DiskQueue.ToList(); // 큐 대신에 리스트 하나 만듦
            tr.Add(new Tracer(currentCur, 0, 0, 0)); //초기 위치랑 이동거리(0), 이동시간(0) 리스트에 추가 
            while (this.DiskQueue.Count > 0)
            {
                shortest_distance = Math.Abs(currentCur - Disk_JOB[0]); //현재위치에서 리스트 맨처음값 뺀 값 == 거리
                shortest_index = 0; //0번째
                shortest_pos = Disk_JOB[0];//0번째 위치
                for (int i = 1; i < Disk_JOB.Count; i++)//0번째는 이미 위에 구해놨으니깐 1번째부터 반복문 시작
                {
                    if (shortest_distance > Math.Abs(currentCur - Disk_JOB[i])) //0번째랑 사이거리랑 비교
                    {
                        shortest_distance = Math.Abs(currentCur - Disk_JOB[i]); 
                        shortest_index = i; 
                        shortest_pos = Disk_JOB[i];
                    }
                } //최종적으로 반복문이 끝나면 최소 거리가 되는 index랑 위치값으로 셋팅됨
                this.DiskQueue.Dequeue();//일단 while문 계속 돌아야되니깐 delete queue는 해줌
                Disk_JOB.Remove(shortest_pos);//list에도 거리 최소되는 위치 삭제
                int nextCur = shortest_pos; //그다음으로 갈 위치
                movement = nextCur - currentCur; // 그 다음 위치 - 현재 위치
                acc = acc + Math.Abs(movement); //이동한 시간
                currentCur = nextCur; //다음위치로 이동
                time=time+m*(double)Math.Abs(movement)+rotation; //전체실행시간
                tr.Add(new Tracer(currentCur, movement, acc, time)); //현재 위치랑 이동거리, 이동시간 리스트에 추가
            }
            this.Clean();
            return tr;
        }

        public List<Tracer> SchedulingWithLOOK(int intialPoint)     //LOOK Scheduling
        {
            List<Tracer> tr = new List<Tracer>();
            List<int> q_list = new List<int>();
            int intial_index = 0;                       //초기 인덱스

            int acc = 0;
            int currentCur = intialPoint;
            int movement = 0;

            
            double time=0;            //전체실행시간
            double m=0.3;              //디스크 드라이브에 따른 상수
            double rotation=8.3;    //평균회전지연시간

            q_list = this.DiskQueue.ToList();           //큐 대신 리스트에 저장
            Clean();                                    //큐내용 삭제
            q_list.Sort();                              //리스트 정렬

            while (true)
            {
                if ( q_list[intial_index] > intialPoint)
                {
                    break;
                }
                if(intial_index+1==q_list.Count)
                {
                    intial_index++;
                    break;
                }
                intial_index++;
            }
            tr.Add(new Tracer(currentCur, 0, 0, 0)); //초기 위치랑 이동거리(0), 이동시간(0) 리스트에 추가 
            
            for (int i = intial_index ; i < q_list.Count; i++)
            {
                this.DiskQueue.Enqueue(q_list[i]);      //초기위치보다 큰 값중에 가까운것부터 큐에 저장
            }
            q_list.Reverse(0,intial_index);
            for (int i = 0; i < intial_index; i++)
            {
                this.DiskQueue.Enqueue(q_list[i]);      //초기위치보다 작은 값중에 가까운것부터 큐에 저장
            }

            while (this.DiskQueue.Count > 0)
            {
                int nextCur = this.DiskQueue.Dequeue();
                movement = nextCur - currentCur;
                acc = acc + Math.Abs(movement);
                currentCur = nextCur;
                time=time+m*(double)Math.Abs(movement)+rotation;        //전체실행시간
                tr.Add(new Tracer(currentCur, movement, acc, time)); //현재 위치랑 이동거리, 이동시간 리스트에 추가
            
            }
            this.Clean();
            return tr;
        }

        public List<Tracer> SchedulingWithC_LOOK(int intialPoint)     //C_LOOK Scheduling
        {
            List<Tracer> tr = new List<Tracer>();
            List<int> q_list = new List<int>();
            int intial_index = 0;                       //초기 인덱스

            int acc = 0;
            int currentCur = intialPoint;
            int movement = 0;
            
            double time=0;            //전체실행시간
            double m=0.3;              //디스크 드라이브에 따른 상수
            double rotation=8.3;    //평균회전지연시간
            
            q_list = this.DiskQueue.ToList();           //큐 대신 리스트에 저장
            Clean();                                    //큐내용 삭제
            q_list.Sort();                              //리스트 정렬

            while (true)
            {
                if ( q_list[intial_index] > intialPoint)
                {
                    break;
                }
                if(intial_index+1==q_list.Count)
                {
                    intial_index++;
                    break;
                }
                intial_index++;
            }

            for (int i = intial_index + 1; i < q_list.Count; i++)
            {
                this.DiskQueue.Enqueue(q_list[i]);      //초기위치보다 큰 값중에 가까운것부터 큐에 저장
            }
            for (int i = 0; i < intial_index; i++)
            {
                this.DiskQueue.Enqueue(q_list[i]);      //초기위치보다 작은 값중에 0에 가까운것부터 큐에 저장
            }
            tr.Add(new Tracer(currentCur, 0, 0,0)); //초기 위치랑 이동거리(0), 이동시간(0) 리스트에 추가 
            while (this.DiskQueue.Count > 0)
            {
                int nextCur = this.DiskQueue.Dequeue();
                movement = nextCur - currentCur;
                if(nextCur<currentCur) movement=0;
                acc = acc + Math.Abs(movement);
                currentCur = nextCur;
                time=time+m*(double)Math.Abs(movement)+rotation;        //전체실행시간
                tr.Add(new Tracer(currentCur, movement, acc, time)); //현재 위치랑 이동거리, 이동시간 리스트에 추가
            }
            this.Clean();
            return tr;
        }

        public List<Tracer> SchedulingWithSCAN(int intialPoint)     //SCAN Scheduling
        {
            List<Tracer> tr = new List<Tracer>();
            List<int> q_list = new List<int>();
            int intial_index = 0; //초기 인덱스

            int acc = 0;
            int currentCur = intialPoint;
            int movement = 0;
            
            double time=0;            //전체실행시간
            double m=0.3;              //디스크 드라이브에 따른 상수
            double rotation=8.3;    //평균회전지연시간
            
            q_list = this.DiskQueue.ToList();           //큐 대신 리스트에 저장
            Clean();                                    //큐내용 삭제
            q_list.Sort();                              //리스트 정렬
            
            while (true)
            {
                if ( q_list[intial_index] > intialPoint)
                {
                    break;
                }
                if(intial_index+1==q_list.Count)
                {
                    intial_index++;
                    break;
                }
                intial_index++;
            }
            for (int i = intial_index; i < q_list.Count; i++)
            {
                this.DiskQueue.Enqueue(q_list[i]);      //초기위치보다 큰 값중에 가까운것부터 큐에 저장
            }
           this.DiskQueue.Enqueue(400);                 //디스크 크기가 400이므로 400까지 scan
            q_list.Reverse(0,intial_index);
            for (int i = 0; i < intial_index; i++)
            {
                this.DiskQueue.Enqueue(q_list[i]);      //초기위치보다 작은 값중에 가까운것부터 큐에 저장
            }

            tr.Add(new Tracer(currentCur, 0, 0,0)); //초기 위치랑 이동거리(0), 이동시간(0) 리스트에 추가 
            while (this.DiskQueue.Count > 0)
            {
                int nextCur = this.DiskQueue.Dequeue();      
                movement = nextCur - currentCur;
                acc = acc + Math.Abs(movement);
                currentCur = nextCur;
 
                time=time+m*(double)Math.Abs(movement)+rotation;        //전체실행시간
                tr.Add(new Tracer(currentCur, movement, acc, time)); //현재 위치랑 이동거리, 이동시간 리스트에 추가
            }
            this.Clean();
            return tr;
        }
        public List<Tracer> SchedulingWithC_SCAN(int intialPoint)     //C-SCAN Scheduling   초기방향 왼쪽
        {
            List<Tracer> tr = new List<Tracer>();
            List<int> q_list = new List<int>();
            int intial_index = 0;                       //초기 인덱스

            int acc = 0;
            int currentCur = intialPoint;
            int movement = 0;
            
            double time=0;            //전체실행시간
            double m=0.3;              //디스크 드라이브에 따른 상수
            double rotation=8.3;    //평균회전지연시간
            
            q_list = this.DiskQueue.ToList();           //큐 대신 리스트에 저장
            Clean();                                    //큐내용 삭제
            q_list.Sort();                              //리스트 정렬

            while (true)
            {
                if ( q_list[intial_index] > intialPoint)
                {
                    break;
                }
                if(intial_index+1==q_list.Count)
                {
                    intial_index++;
                    break;
                }
                intial_index++;
            }
            tr.Add(new Tracer(currentCur, 0, 0, 0));       //초기 위치랑 이동거리(0), 이동시간(0) 리스트에 추가 
            for (int i = intial_index + 1; i < q_list.Count; i++)
            {
                this.DiskQueue.Enqueue(q_list[i]);      //초기위치보다 큰 값중에 가까운것부터 큐에 저장
            }
           this.DiskQueue.Enqueue(400);                 //400까지 scan
            this.DiskQueue.Enqueue(0);                  //0부터 scan
            for (int i = 0; i < intial_index; i++)
            {
                this.DiskQueue.Enqueue(q_list[i]);      //초기위치보다 작은 값중에 0에 가까운것부터 큐에 저장
            }

                while (this.DiskQueue.Count > 0)
            {
                int nextCur = this.DiskQueue.Dequeue();
                movement = nextCur - currentCur;
                if(currentCur==400) movement=0;
                acc = acc + Math.Abs(movement);
                currentCur = nextCur;

                time=time+m*(double)Math.Abs(movement)+rotation;    //전체실행시간
                tr.Add(new Tracer(currentCur, movement, acc, time)); //현재 위치랑 이동거리, 이동시간 리스트에 추가
            }

            return tr;

        }
    }
}
