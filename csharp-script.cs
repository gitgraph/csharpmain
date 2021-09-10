


    float cmx = 0;

    int dc = 0;


    public int bricks0 = 0;

    public int bricks1 = 1;


    int graphicr = 0;

    public int cameraUpdate = 1;



    /**
    
      Documentation - LevelUpdate
    
   
      LevelUpdate runs from an Update() thread for every frame and this function
      displaying/hiding objects when they appear within the set boundaries. 
    
  
    
    */





    public void LevelUpdate()
    {



        if (graphicr == 1)
        {





            if (clevel != 0)
            {


                if (levelCreate.transform.childCount > 0 && levelCreate.transform.GetChild(0).childCount > 0 && levelCreate.transform.GetChild(0).GetChild(0).childCount > 0)
                {





                    GameObject brickf = levelCreate.transform.GetChild(0).GetChild(0).GetChild(0).gameObject;

                    GameObject brickl = levelCreate.transform.GetChild(levelCreate.transform.childCount - 1).GetChild(0).GetChild(0).gameObject;





                    if (bricks != null && brickf != null && bricks.Length > 0 && brickl != null && maincamera != null)
                    {




                        if ((maincamera.transform.localPosition.x - (brickf.transform.position.x + ((bricks[bricks0][0][1] / 2) * tile))) > 60)
                        {

                            ///  ((cmx - brickf.transform.position.x) + 10) 
                            ///  


                            string rs = Regex.Match(levelCreate.transform.GetChild(0).gameObject.name.ToString(), @"\d+").Value;


                            //  int t = Int32.Parse(rs);


                            if (treebuildfrontgroup.transform.childCount > 0)
                            {

                                string trs = treebuildfrontgroup.transform.GetChild(0).transform.name.ToString();

                                string rm = Regex.Match(trs, @"\d+").Value;

                                int tp = Int32.Parse(rm);

                                if (bricks0 == tp)
                                {

                                    Destroy(treebuildfrontgroup.transform.GetChild(0).gameObject);

                                }

                            }


                            if (treebuildbackgroup.transform.childCount > 0)
                            {
                                string tb = treebuildbackgroup.transform.GetChild(0).transform.name.ToString();

                                string rmb = Regex.Match(tb, @"\d+").Value;

                                int tbp = Int32.Parse(rmb);

                                if (bricks0 == tbp)
                                {
                                    Destroy(treebuildbackgroup.transform.GetChild(0).gameObject);

                                }

                            }

                            //    Debug.Log("Destroy 0");

                            Destroy(levelCreate.transform.GetChild(0).gameObject);

                            cmx = maincamera.transform.localPosition.x;


                            bricks0 += 1;


                        }
                        else if (maincamera.transform.localPosition.x - ((brickf.transform.position.x - ((bricks[bricks0][0][1] / 2) * tile)) - ((bricks[bricks0 <= 0 ? 0 : bricks0 - 1][0][1] / 2) * tile)) < 40)
                        {

                            if (bricks0 > 0)
                            {
                                bricks0 -= 1;

                                //    Debug.Log("BuildLawn 0");

                                BuildLevel(bricks0);
                            }


                        }




                        if (bricks1 < (bl10) && ((brickl.transform.position.x - ((bricks[bricks1][0][1] / 2) * tile)) - maincamera.transform.localPosition.x) > 60)
                        {


                            // (( (brickl.transform.position.x - ((bricks[bricks1][0][1] / 2) * tile)) - cmx) + 20)


                            // (( brickl.transform.position.x - cmx ) + 10)




                            if (treebuildfrontgroup.transform.childCount > 0)
                            {

                                string trs = treebuildfrontgroup.transform.GetChild(treebuildfrontgroup.transform.childCount - 1).transform.name.ToString();

                                string rm = Regex.Match(trs, @"\d+").Value;

                                int tp = Int32.Parse(rm);

                                if (bricks1 == tp)
                                {

                                    Destroy(treebuildfrontgroup.transform.GetChild(treebuildfrontgroup.transform.childCount - 1).gameObject);

                                }

                            }



                            if (treebuildbackgroup.transform.childCount > 0)
                            {
                                string tb = treebuildbackgroup.transform.GetChild(treebuildbackgroup.transform.childCount - 1).transform.name.ToString();

                                string rmb = Regex.Match(tb, @"\d+").Value;

                                int tbp = Int32.Parse(rmb);

                                if (bricks1 == tbp)
                                {
                                    Destroy(treebuildbackgroup.transform.GetChild(treebuildbackgroup.transform.childCount - 1).gameObject);

                                }

                            }






                            GameObject d = levelCreate.transform.GetChild(levelCreate.transform.childCount - 1).gameObject;

                            if (d != null)
                            {

                                //  Debug.Log("Destroy 1");
                                Destroy(d);

                                bricks1 -= 1;
                            }




                            cmx = maincamera.transform.localPosition.x;






                        }


                        else if (bricks1 < (bl10) && (((brickl.transform.position.x + ((bricks[bricks1][0][1] / 2) * tile)) + ((bricks[bricks1 + 1][0][1] / 2) * tile)) - maincamera.transform.localPosition.x) < 40)
                        {
                            // 0  1  2  3  4  5 

                            // 1  2  3  4  5  6

                            // bl10 = 6 

                            // brl++;

                            if (bricks1 < (bl10))
                            {
                               
                                bricks1 += 1;

                                BuildLevel(bricks1);
                            }


                        }



                    }

                }
            }



        }




    }


























   /**
      Documentation - BuildLevel
      
      Generating game objects at certain positions from a multiple dimensional array[][][]
   
  
   */




    public void BuildLevel(int p)
    {





        //   int l = 0;

        //   Debug.Log("Brick");

        int bl = bricks.Length;

        //    Debug.Log("Brick Length:" + bl);

        int br = bricks.Rank;

        //    Debug.Log("Brick Rank:" + br);

        int bc = 0;

        //    Debug.Log("Brick GetLength:" + bc);


        //  int pc = bricks.GetLength(0);

        //     Debug.Log("Brick GetLength 0 pc:" + pc);

        //      Debug.Log("Brick Length pc:" + pc);








        //    p0 = bl10;


        //   bl10 += 10;


        p0 = 0;
        bl10 = bl;



        if (runner == 1)
        {

            //   p0 = 1;
        }


        if (clevel != 12)
        {


        }
        else
        {


            //  p0 = 0;
            //  bl10 = 10;


            /*  if( bl10 > bl )
              {

                  bl10 = bl;
              }*/


        }





        /////  for (int p = p0; p < bl10; p++)  {



        //  bc = bricks[p].GetLength(0);

        bc = bricks[p].Length;

        //     Debug.Log("Brick Count Length:" + bc);





        GameObject levelBrick = new GameObject("Brick" + p);
        levelBrick.transform.parent = levelCreate.gameObject.transform;





        //    levelBrick.transform.localScale = new Vector3(1, 1, 0);

        //   levelBrick.transform.localPosition = new Vector3(0, 0);



        treeCreated1 = 1;

        treeCreated2 = 1;


        ///   lawnbuild = 1;



        if (lawnbuild == 1)
        {



            if (p == bricks0)
            {

                levelBrick.transform.SetSiblingIndex(0);

                //   cx += ((w / 2) * tile) + ((nWidth / 2) * tile) + (x * tile) + (border * 2);

                /*
                float wc = 0;

                int fw = p;

                for( int f = 0; f< fw; f++ )
                {
                    wc += bricks[f][0][1];
                }*/

                cx = brickcxy[p, 0];


                cy = brickcxy[p, 1];


                /*
                cy = -((bricks[0][0][2] * tile) / 2) - 2;  // 5

                cx = ((bricks[0][0][1] * tile) / 2) - (16 * tile);  // 9
                */

            }

            if (p == bricks1)
            {

                cx = brickcxy[p, 0];

                cy = brickcxy[p, 1];

            }


        }

        else
        {


            cx = brickcxy[p, 0];

            cy = brickcxy[p, 1];


        }





        tx = cx;
        ty = cy;




        for (int b = 0; b < bc; b++)
        {

            float s = bricks[p][b][0];


            if (s == 1)
            {

                float w = bricks[p][b][1];

                float h = bricks[p][b][2];

                float x = bricks[p][b][3];
                float y = bricks[p][b][4];

           
              if( x >= 1.4f )   
              {

                  x = 1.0f;
              }




                // new float[][] { new float[] { 1, 8, 10, 0, 1, 2, 4 }, },
                float t = 0;
                float d = 0;

                if (bricks[p][b].Length > 5)
                {
                    t = bricks[p][b][5];

                    d = bricks[p][b][6];


                    /*if (inc_moving_brick == 0)
                    {
                        y = 1.5f;
                    }*/

                }


                if (inc_moving_brick == 0)
                {
                    t = 0;
                    d = 0;



                }



                GameObject brickGroup = new GameObject("BrickGroup");

                brickGroup.transform.localScale = new Vector3(1, 1, 0);


                // brickGroup.tag = "BrickTag";

                if (t == 0)
                {

                    brickGroup.transform.parent = levelBrick.transform;
                }

                GameObject move = null;

                if (t == 1 || t == 2)
                {



                    move = Instantiate(preMove, Vector3.zero, Quaternion.identity);


                    brickGroup.transform.parent = move.gameObject.transform;


                    move.transform.parent = levelBrick.gameObject.transform;

                }



                if (t == 1)
                {
                    move.transform.GetComponent<FollowPath>().vectorp[0] = new Vector3(0, 0);

                    move.transform.GetComponent<FollowPath>().vectorp[1] = new Vector3(0 + d, 0);

                }
                if (t == 2)
                {
                    move.transform.GetComponent<FollowPath>().vectorp[0] = new Vector3(0, 0);

                    move.transform.GetComponent<FollowPath>().vectorp[1] = new Vector3(0, 0 + d);


                }




                float border = 0.07f;


                GameObject brickB = Instantiate(preBrickR, Vector3.zero, Quaternion.identity);

                brickB.transform.parent = brickGroup.transform;

                brickB.transform.GetComponent<SpriteRenderer>().sortingOrder = 31;


                brickB.transform.GetComponent<SpriteRenderer>().color = new Color32(72, 67, 58, 255);

                brickB.transform.localPosition = new Vector3((cx + (x * tile)), (cy + (y * tile) - (border * 2)));

                brickB.transform.localScale = new Vector3((w * tile) + (border * 2), h * tile, 0);






                GameObject brick = Instantiate(preBrick, Vector3.zero, Quaternion.identity);

                brick.transform.parent = brickGroup.transform;

                brick.transform.GetComponent<SpriteRenderer>().sortingOrder = 32;


                brick.transform.GetComponent<SpriteRenderer>().color = new Color32(43, 50, 59, 255);

                brick.transform.localPosition = new Vector3((cx + (x * tile) + border), (cy + (y * tile)));

                brick.transform.localScale = new Vector3(w * tile, h * tile, 0);


                if (t != 0)
                {
                    brick.tag = "BrickMove";
                }



                GameObject brick2 = Instantiate(preBrickR, Vector3.zero, Quaternion.identity);
                brick2.transform.parent = brickGroup.transform;

                brick2.transform.GetComponent<SpriteRenderer>().sortingOrder = 33;

                brick2.transform.GetComponent<SpriteRenderer>().color = new Color32(40, 47, 56, 255);

                brick2.transform.localPosition = new Vector3((cx + (x * tile) + border), (((cy + (y * tile))) - (0.5f * tile)));

                brick2.transform.localScale = new Vector3(w * tile, h * tile, 0);



                GameObject brick3 = Instantiate(preBrickR, Vector3.zero, Quaternion.identity);
                brick3.transform.parent = brickGroup.transform;

                brick3.transform.GetComponent<SpriteRenderer>().color = new Color32(43, 50, 59, 255);

                brick3.transform.localPosition = new Vector3((cx + (x * tile) + border), ((cy + (y * tile))) - (1f * tile));

                brick3.transform.localScale = new Vector3(w * tile, h * tile, 0);

                brick3.transform.GetComponent<SpriteRenderer>().sortingOrder = 34;


                GameObject brick4 = Instantiate(preBrickR, Vector3.zero, Quaternion.identity);
                brick4.transform.parent = brickGroup.transform;

                brick4.transform.GetComponent<SpriteRenderer>().color = new Color32(40, 47, 56, 255);

                brick4.transform.localPosition = new Vector3((cx + (x * tile) + border), ((cy + (y * tile))) - (1.5f * tile));

                brick4.transform.localScale = new Vector3(w * tile, h * tile, 0);

                brick4.transform.GetComponent<SpriteRenderer>().sortingOrder = 35;





                cy += y;

                if (p < (bl - 1))
                {
                    //   Debug.Log("Brick p:" + p + " b:" + b);


                    cy += ((h * tile) / 2) - ((bricks[p + 1][b][2] * tile) / 2);


                    float nWidth = bricks[p + 1][b][1];


                    cx += ((w / 2) * tile) + ((nWidth / 2) * tile) + (x * tile) + (border * 2);

                }



            }


            if (s == 2)
            {


                float g = bricks[p][b][1];


                float w = bricks[p][0][1];

                float h = bricks[p][0][2];

                //  float x = bricks[p][0][3];
                //   float y = bricks[p][0][4];




                GameObject brick = Instantiate(preBrick, Vector3.zero, Quaternion.identity);

                brick.transform.parent = levelBrick.gameObject.transform;



                //  float gh = (5 - (((ty+y) + (h / 2)) + g)) * 2;


                //   float ghh = (9 - ((5 - ((ty + y) + ((h / 2)))) - g));


                float ght = (g * tile) + ((ty + ((h / 2) * tile)) + ((8 * tile) / 2));


                brick.transform.localPosition = new Vector3(tx, ght);

                brick.transform.localScale = new Vector3(w * tile, 8 * tile, 0);



            }


            if (s == 3)
            {

                float fx = bricks[p][b][1];


                float w = bricks[p][0][1];

                float h = bricks[p][0][2];

                float x = bricks[p][0][3];
                float y = bricks[p][0][4];



                int f = (int)bricks[p][b][2];


                if (flowerc[f, 0] == 1)
                {




                    GameObject flower = Instantiate(preFlower, Vector3.zero, Quaternion.identity);

                    flower.name = "" + f;

                    flower.transform.parent = levelBrick.gameObject.transform;

                    float fy = flower.transform.Find("FlowerC").GetComponent<SpriteRenderer>().bounds.size.y;


                    float gy = (y * tile) + ((h / 2) * tile);


                    float btx = (tx - ((w / 2) * tile)) + (x * tile);


                    flower.transform.localPosition = new Vector3((btx + (fx * tile)), ((ty + gy) + (fy / 2)));

                }


            }

            if (s == 4)
            {

                //   float hp = bricks[p][b][2];

                float hx = bricks[p][b][1];



                float w = bricks[p][0][1];

                float h = bricks[p][0][2];

                float x = bricks[p][0][3];
                float y = bricks[p][0][4];



                float hp = 2;

                float hvx = 0;


                for (int hv = 0; hv < 4; hv++)
                {

                    hp = UnityEngine.Random.Range(1, 5);

                    //  Debug.Log("house hp:" + hp);


                    preHouse = (GameObject)(Resources.Load("house" + hp));

                    GameObject house = Instantiate(preHouse, Vector3.zero, Quaternion.identity);

                    house.transform.parent = levelBrick.gameObject.transform;


                    //  Houses  16 - 21



                    house.transform.GetComponent<SpriteRenderer>().sortingOrder = 35 - (int)hp;


                    float hw = house.transform.GetComponent<SpriteRenderer>().bounds.size.x;

                    float hy = house.transform.GetComponent<SpriteRenderer>().bounds.size.y;

                    float btx = (tx - ((w / 2) * tile)) + (x * tile) + (hw / 2);

                    float gy = (y * tile) + ((h / 2) * tile);


                    house.transform.localPosition = new Vector3((btx + (hx * tile)) + hvx, ((ty + gy) + (hy / 2)));


                    hvx += (hw - 1);




                }


            }




            if (s == 5)
            {

                float hx = bricks[p][b][1];

                float w = bricks[p][0][1];
                float h = bricks[p][0][2];
                float x = bricks[p][0][3];
                float y = bricks[p][0][4];

                GameObject sTree = Instantiate(preSmallTree, Vector3.zero, Quaternion.identity);
                sTree.transform.parent = levelBrick.gameObject.transform;

                float hw = sTree.transform.GetComponent<SpriteRenderer>().bounds.size.x;
                float hy = sTree.transform.GetComponent<SpriteRenderer>().bounds.size.y;

                float gy = (y * tile) + ((h / 2) * tile);


                float btx = (tx - ((w / 2) * tile)) + (x * tile) + (hw / 2);


                sTree.transform.localPosition = new Vector3((btx + (hx * tile)), ((ty + gy)) + (hy / 2) - 0);

            }
            if (s == 6)
            {

                float hx = bricks[p][b][1];

                float w = bricks[p][0][1];
                float h = bricks[p][0][2];
                //  float x = bricks[p][0][3];
                float y = bricks[p][0][4];









                GameObject tree;


                float tfOffset = 0.2f;



                float treeAddx;

                treeAddx = 0;


                float startpx = 13 * tile;



                if (treeCount % 2 == 0)
                {


                    if (treeCreated1 == 1)
                    {

                        treeCF = new GameObject("TreeF" + p);

                        treeCreated1 = 0;
                    }



                    tree = Instantiate(preTree2, Vector3.zero, Quaternion.identity);


                    tree.transform.parent = treeCF.gameObject.transform;

                    treeCF.transform.parent = treebuildfrontgroup.gameObject.transform;

                    tree.transform.GetComponent<SpriteRenderer>().sortingOrder = 70;

                    tfOffset = 0.2f;




                    treeAddx = (0 + maincamera.transform.localPosition.x) - startpx;

                }
                else
                {


                    if (treeCreated2 == 1)
                    {



                        treeCB = new GameObject("TreeB" + p);


                        treeCreated2 = 0;
                    }



                    tree = Instantiate(preTree, Vector3.zero, Quaternion.identity);

                    tfOffset = -0.2f;

                    tree.transform.parent = treeCB.gameObject.transform;

                    treeCB.transform.parent = treebuildbackgroup.gameObject.transform;

                    tree.transform.GetComponent<SpriteRenderer>().sortingOrder = 17;


                    treeAddx = (0 - maincamera.transform.localPosition.x) - startpx;

                }


                if (bricks0 == p)
                {

                    if (treeCreated1 == 0)
                    {
                        treeCF.transform.SetSiblingIndex(0);
                    }

                    if (treeCreated2 == 0)
                    {
                        treeCB.transform.SetSiblingIndex(0);
                    }



                }




                //  float hw = tree.transform.GetComponent<SpriteRenderer>().bounds.size.x;
                float hy = tree.transform.GetComponent<SpriteRenderer>().bounds.size.y;



                tree.transform.localScale = new Vector3(1, 1, 0);


                float gy = (y * tile) + ((h / 2) * tile);
                float btx = tx - ((w / 2) * tile);






                // float cameraWidth = 22;




                //  float brickX = (btx + (hx * tile));


                //    float treeAddx = (brickX - (cameraWidth + 9)) * tfOffset;


                treeCount++;


                treeAddx = 0;



                tree.transform.localPosition = new Vector3((btx + (hx * tile)) + (treeAddx), (((ty + gy) - (hy / 2)) + 6) > -2 ? -2 : (((ty + gy) - (hy / 2)) + 6));





            }

            if (s == 7)
            {

                float hx = bricks[p][b][1];

                float w = bricks[p][0][1];
                float h = bricks[p][0][2];
                float x = bricks[p][0][3];
                float y = bricks[p][0][4];

                float m = 10;

                if (bricks[p][b].Length > 2)
                {
                    m = bricks[p][b][2];


                }
                GameObject pbox = prePostbox;


                if (m != 10)
                {
                    pbox = prePostboxM;

                }


                GameObject postbox = Instantiate(pbox, Vector3.zero, Quaternion.identity);
                postbox.transform.parent = levelBrick.gameObject.transform;

                if (m != 10)
                {
                    postbox.name = "" + m;
                }




                float hw = postbox.transform.GetComponent<SpriteRenderer>().bounds.size.x;
                float hy = postbox.transform.GetComponent<SpriteRenderer>().bounds.size.y;

                float gy = (y * tile) + ((h / 2) * tile);


                float btx = (tx - ((w / 2) * tile)) + (x * tile) + (hw / 2);



                //    postbox.transform.localPosition = new Vector3(btx + (hx * tile), (((ty + gy)) + (hy / 2)) - (1.5f * tile));

                postbox.transform.localPosition = new Vector3(btx + (hx * tile), (((ty + gy)) + (hy / 2)));



            }

            if (s == 8)
            {

                float hx = bricks[p][b][1];

                float w = bricks[p][0][1];
                float h = bricks[p][0][2];
                float x = bricks[p][0][3];
                float y = bricks[p][0][4];


                //  float fx = 0;



                preFence = (GameObject)(Resources.Load("Fence1"));



                GameObject fence = Instantiate(preFence, Vector3.zero, Quaternion.identity);
                fence.transform.parent = levelBrick.gameObject.transform;

                float hw = fence.transform.GetChild(0).GetComponent<SpriteRenderer>().bounds.size.x;
                float hy = fence.transform.GetChild(0).GetComponent<SpriteRenderer>().bounds.size.y;

                float gy = (y * tile) + ((h / 2) * tile);


                float btx = (tx - ((w / 2) * tile)) + (x * tile) + (hw / 2);



                fence.transform.localPosition = new Vector3((btx + (hx * tile)), (((ty + gy)) + (hy / 2)));




            }



            if (s == 9 && inc_enemies == 1)
            {
                //  new float[] { 9, 2, 1, 4 }  },


                float hx = bricks[p][b][1];

                float t = 0;
                float d = 0;


                if (bricks[p][b].Length > 2)
                {
                    t = bricks[p][b][2];

                    d = bricks[p][b][3];

                }



                float w = bricks[p][0][1];
                float h = bricks[p][0][2];
                float x = bricks[p][0][3];
                float y = bricks[p][0][4];

                GameObject stone = Instantiate(preStone, Vector3.zero, Quaternion.identity);
                stone.transform.parent = levelBrick.gameObject.transform;

                float hw = stone.transform.GetComponent<SpriteRenderer>().bounds.size.x;
                float hy = stone.transform.GetComponent<SpriteRenderer>().bounds.size.y;

                float gy = (y * tile) + ((h / 2) * tile);


                float btx = (tx - ((w / 2) * tile)) + (x * tile) + (hw / 2);


                stone.transform.localPosition = new Vector3((btx + (hx * tile)), ((ty + gy)) + (hy / 2));

                //  stone.transform.GetComponent<FollowPath>().currentPath = 2;


                if (t == 1)
                {

                    stone.transform.GetComponent<FollowPath>().vectorp[0] = new Vector3((btx + (hx * tile)), ((ty + gy)) + (hy / 2));

                    stone.transform.GetComponent<FollowPath>().vectorp[1] = new Vector3(((btx + (hx * tile))) + ((d * tile) - (hw / 2)), ((ty + gy)) + (hy / 2));


                }



                if (t == 2)
                {


                }

                if (t == 0)
                {
                    stone.transform.GetComponent<FollowPath>().vectorp[0] = new Vector3((btx + (hx * tile)), ((ty + gy)) + (hy / 2));

                    stone.transform.GetComponent<FollowPath>().vectorp[1] = new Vector3((btx + (hx * tile)), ((ty + gy)) + (hy / 2));


                }






                //  stone.transform.GetComponent<FollowPath>().pathPoints[2] = stone.transform;


            }




            if (s == 10)
            {
                float hx = bricks[p][b][1];

                float fl = bricks[p][b][2];

                float w = bricks[p][0][1];
                float h = bricks[p][0][2];
                float x = bricks[p][0][3];
                float y = bricks[p][0][4];

                // GameObject finish = Instantiate(preFinish, Vector3.zero, Quaternion.identity);
                // finish.transform.parent = levelBrick.gameObject.transform;

                //float hw = finish.transform.GetComponent<SpriteRenderer>().bounds.size.x;
                //  float hy = finish.transform.GetComponent<SpriteRenderer>().bounds.size.y;

                float gy = (y * tile) + ((h / 2) * tile);
                float btx = tx - ((w / 2) * tile);

                //  finish.transform.localPosition = new Vector3((btx + (hx * tile)), ty + gy + (hy / 2) - 2);








                finishn = 1;

                GameObject checkpoint = Instantiate(preCheckpoint, Vector3.zero, Quaternion.identity);
                checkpoint.transform.parent = levelBrick.gameObject.transform;


                checkpoint.name = "" + fl;


                int FinishdbLevel = PlayerPrefs.GetInt("Level", 1);

                int FinishdbLevel2 = PlayerPrefs.GetInt("Level2", 1);




                /*
                 * 
                 *  2 
                 *  
                 *  1  ----  2
                 * 
                 * 
                 * 
                 *  5
                 * 
                 * 
                 */



                /*
                 * 
                 *    FinishdbLevel   1
                 * 
                 *    fl 2
                 *    
                 *    clevel   1
                 * 
                 * 
                 * 
                 * 
                 */




                if (world == 1)
                {

                    // Default checkpoint unflagged


                    ///     start             go back        go foward                                   

                    if ((fl == clevel) || clevel > fl || clevel < FinishdbLevel)
                    {

                        checkpoint.transform.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("g12703");


                        //  finish.transform.tag = "Untagged";

                    }


                    if ((fl) == (clevel + 1) && clevel == FinishdbLevel)
                    {

                        checkpoint.transform.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("g12691");

                    }

                }
                else if (world == 2)
                {



                    if (fl == (clevel - 10) || (clevel - 10) > fl || (clevel - 10) < FinishdbLevel2)
                    {

                        checkpoint.transform.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("g12703");


                        //  finish.transform.tag = "Untagged";

                    }


                    if (fl == ((clevel - 10) + 1) && (clevel - 10) == FinishdbLevel2)
                    {

                        checkpoint.transform.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("g12691");

                    }


                }




                //  checkpoint.tag = "checkpoint";

                //  checkpoint.name = "checkpoint" + clevel;

                float hw1 = checkpoint.transform.GetComponent<SpriteRenderer>().bounds.size.x;
                float hy1 = checkpoint.transform.GetComponent<SpriteRenderer>().bounds.size.y;

                float gy1 = (y * tile) + ((h / 2) * tile);

                float btx1 = (tx - ((w / 2) * tile)) + (x * tile) + (hw1 / 2);




                checkpoint.transform.localPosition = new Vector3((btx1 + (hx * tile)), (((ty + gy1)) + (hy1 / 2)));


                checkpointc = checkpoint;



                finishL = checkpointc.transform.position.x;



                finishd = 1;

                //  checkpoint.transform.GetComponent<SpriteRenderer>().


            }




            if (s == 11)
            {
                float hx = bricks[p][b][1];

                float w = bricks[p][0][1];
                float h = bricks[p][0][2];
                float x = bricks[p][0][3];
                float y = bricks[p][0][4];

                //  float fx = 0;

                GameObject sign = Instantiate(preSign, Vector3.zero, Quaternion.identity);
                sign.transform.parent = levelBrick.gameObject.transform;

                float hw = sign.transform.GetComponent<SpriteRenderer>().bounds.size.x;
                float hy = sign.transform.GetComponent<SpriteRenderer>().bounds.size.y;

                float gy = (y * tile) + ((h / 2) * tile);

                float btx = (tx - ((w / 2) * tile)) + (x * tile) + (hw / 2);

                sign.transform.localPosition = new Vector3((btx + (hx * tile)), (((ty + gy)) + (hy / 2)));

            }




            if (s == 12)
            {
                float hx = bricks[p][b][1];

                float w = bricks[p][0][1];
                float h = bricks[p][0][2];
                float x = bricks[p][0][3];
                float y = bricks[p][0][4];

                // float fx = 0;

                GameObject signarea = Instantiate(preSignArea, Vector3.zero, Quaternion.identity);
                signarea.transform.parent = levelBrick.gameObject.transform;

                float hw = signarea.transform.GetComponent<SpriteRenderer>().bounds.size.x;
                float hy = signarea.transform.GetComponent<SpriteRenderer>().bounds.size.y;

                float gy = (y * tile) + ((h / 2) * tile);


                float btx = (tx - ((w / 2) * tile)) + (x * tile) + (hw / 2);


                signarea.transform.localPosition = new Vector3((btx + (hx * tile)), (((ty + gy)) + (hy / 2)));

            }




            if (s == 13)
            {
                float hx = bricks[p][b][1];

                float w = bricks[p][0][1];
                float h = bricks[p][0][2];
                float x = bricks[p][0][3];
                float y = bricks[p][0][4];

                // float fx = 0;

                GameObject lamp = Instantiate(preLamp, Vector3.zero, Quaternion.identity);
                lamp.transform.parent = levelBrick.gameObject.transform;

                float hw = lamp.transform.GetComponent<SpriteRenderer>().bounds.size.x;
                float hy = lamp.transform.GetComponent<SpriteRenderer>().bounds.size.y;

                float gy = (y * tile) + ((h / 2) * tile);

                float btx = (tx - ((w / 2) * tile)) + (x * tile) + (hw / 2);

                lamp.transform.localPosition = new Vector3((btx + (hx * tile)), (((ty + gy)) + (hy / 2)));

            }


            if (s == 14)
            {
                float hx = bricks[p][b][1];

                float w = bricks[p][0][1];
                float h = bricks[p][0][2];
                float x = bricks[p][0][3];
                float y = bricks[p][0][4];

                //  float fx = 0;

                GameObject bush = Instantiate(preBush, Vector3.zero, Quaternion.identity);
                bush.transform.parent = levelBrick.gameObject.transform;

                float hw = bush.transform.GetComponent<SpriteRenderer>().bounds.size.x;
                float hy = bush.transform.GetComponent<SpriteRenderer>().bounds.size.y;

                float gy = (y * tile) + ((h / 2) * tile);

                float btx = (tx - ((w / 2) * tile)) + (x * tile) + (hw / 2);

                bush.transform.localPosition = new Vector3((btx + (hx * tile)), (((ty + gy)) + (hy / 2)));

            }


            if (s == 15)
            {
                float hx = bricks[p][b][1];
                float fx = 0;

                float w = bricks[p][0][1];
                float h = bricks[p][0][2];
                float x = bricks[p][0][3];
                float y = bricks[p][0][4];


                if (bricks[p][b].Length > 2)
                {

                    fx = bricks[p][b][2];

                }

                GameObject fenceb = preFence3;


                if (fx == 1)
                {
                    fenceb = preFence5;

                }




                //float fx = 0;

                GameObject fence3 = Instantiate(fenceb, Vector3.zero, Quaternion.identity);
                fence3.transform.parent = levelBrick.gameObject.transform;


                float hw = 0; float hy = 0;


                if (fx == 1)
                {

                    hw = fence3.transform.GetChild(0).transform.GetComponent<SpriteRenderer>().bounds.size.x;
                    hy = fence3.transform.GetChild(0).transform.GetComponent<SpriteRenderer>().bounds.size.y;

                }
                if (fx == 0)
                {
                    hw = fence3.transform.GetComponent<SpriteRenderer>().bounds.size.x;
                    hy = fence3.transform.GetComponent<SpriteRenderer>().bounds.size.y;

                }
                float gy = (y * tile) + ((h / 2) * tile);

                float btx = (tx - ((w / 2) * tile)) + (x * tile) + (hw / 2);

                fence3.transform.localPosition = new Vector3((btx + (hx * tile)), (((ty + gy)) + (hy / 2)));

            }






            if (s == 16 && inc_wrench == 1)
            {
                float hx = bricks[p][b][1];

                float w = bricks[p][0][1];
                float h = bricks[p][0][2];
                float x = bricks[p][0][3];
                float y = bricks[p][0][4];

                //float fx = 0;

                GameObject wrench = Instantiate(preWrench, Vector3.zero, Quaternion.identity);
                wrench.transform.parent = levelBrick.gameObject.transform;

                float hw = wrench.transform.GetComponent<SpriteRenderer>().bounds.size.x;
                float hy = wrench.transform.GetComponent<SpriteRenderer>().bounds.size.y;

                float gy = (y * tile) + ((h / 2) * tile) + (2 * tile);

                float btx = (tx - ((w / 2) * tile)) + (x * tile) + (hw / 2);

                wrench.transform.localPosition = new Vector3((btx + (hx * tile)), (((ty + gy)) + (hy / 2)));

            }






            if (s == 17 && inc_fuel == 1)
            {
                float hx = bricks[p][b][1];

                float w = bricks[p][0][1];
                float h = bricks[p][0][2];
                float x = bricks[p][0][3];
                float y = bricks[p][0][4];

                //float fx = 0;

                GameObject efuel = Instantiate(preFuel, Vector3.zero, Quaternion.identity);
                efuel.transform.parent = levelBrick.gameObject.transform;

                float hw = efuel.transform.GetComponent<SpriteRenderer>().bounds.size.x;
                float hy = efuel.transform.GetComponent<SpriteRenderer>().bounds.size.y;

                float gy = (y * tile) + ((h / 2) * tile) + (2 * tile);

                float btx = (tx - ((w / 2) * tile)) + (x * tile) + (hw / 2);

                efuel.transform.localPosition = new Vector3((btx + (hx * tile)), (((ty + gy)) + (hy / 2)));


            }








        }








        ///  }








        //   treebuild.transform.localScale = new Vector3(worldScale, worldScale, 0);

        //   treebuildback.transform.localScale = new Vector3(worldScale, worldScale, 0);




        //  levelScale.transform.localPosition = new Vector3(0.5f, 0, 0);



        //  levelScale.transform.localScale = new Vector3(worldScale, worldScale, 0);

        if (treeCreated1 == 0)
        {

            treeCF.transform.localScale = new Vector3(worldScale, worldScale, 0);

        }

        if (treeCreated2 == 0)
        {
            treeCB.transform.localScale = new Vector3(worldScale, worldScale, 0);

        }




        levelBrick.transform.localPosition = new Vector3(-9f, 0, 0);

        levelBrick.transform.localScale = new Vector3(worldScale, worldScale, 0);


        if (runner == 1)
        {

            // GraphicGenerate.buildMountain(clevel+1);

        }





    }




































    public void RunGame()
    {


        points = new float[][][]
        {

            new float [][]
            {

            new float [] { 1, 7, 1  },

            new float [] { 3, 2, 2 },

            new float [] { 1, 13, 1  },

            new float [] { 3, 2, 1 },

            new float [] { 4, 1 },

            new float [] { 3, 2, 1 },

            new float [] { 2, 16, 1, 1  },

            new float [] { 2, 20, 1, 1  },


            new float [] { 1, 29, 1  },

            new float [] { 2, 33, 1, 1  },

            new float [] { 2, 35, 1, 1  },



            new float [] { 2, 50, 1, 1  },

            new float [] { 3, 2, 1  },


            new float [] { 2, 54, 1, 1  },


            new float [] { 1, 63, 1  },

            new float [] { 2, 68, 1, 1  },

            new float [] { 1, 81, 1  },

            new float [] { 2, 87, 1, 1  },

            new float [] { 2, 92, 1, 1  },

            new float [] { 2, 98, 1, 1  },

            new float [] { 1, 106, 1  },


            new float [] { 2, 134, 1, 1  },

            new float [] { 2, 137, 1, 1  },



            new float [] { 1, 149, 1  },

            new float [] { 2, 152, 1, 1  },


            new float [] { 1, 165, 1  },

            new float [] { 2, 168, 1, 1  },


            new float [] { 1, 175, 1  },

            new float [] { 2, 178, 1, 1  },


            new float [] { 1, 185, 1  },

            new float [] { 3, 1, 1 },

            new float [] { 2, 190, 1, 1  },

             new float [] { 2, 195, 1, 1  },

            new float [] { 2, 200, 1, 1  },


            new float [] { 1, 222, 1  },

             new float [] { 3, 2, 1 },

            new float [] { 2, 226, 1, 1 },

        //    new float [] { 2, 225, 1, 1 },

        //    new float [] { 1, 225, 1  },


             new float [] { 3, 6, 1 },

               new float [] { 2, 228, 1, 1 },

            new float [] { 1, 228, 1  },


            new float [] { 1, 243, 1  },

             new float [] { 1, 245, 1  },

             new float [] { 3, 2, 1 },

            new float [] { 2, 246, 1, 1 },

        //    new float [] { 2, 246, 1, 1 },

             new float [] { 3, 4, 1 },

              new float [] { 2, 250, 1, 1 },


               new float [] { 3, 4, 1 },


              new float [] { 1, 252, 1 },

              new float [] { 1, 254, 1 },


              new float [] { 1, 255, 1 },

              new float [] { 1, 256, 1 },

              new float [] { 1, 257, 1 },

               new float [] { 3, 3, 1 },

              new float [] { 1, 258, 1 },

               new float [] { 2, 261, 1, 1 },

               new float [] { 1, 262, 1 },

               new float [] { 2, 267, 1, 1 },

               new float [] { 2, 271, 1, 1 },


               new float [] { 1, 275, 1 },

                new float [] { 3, 2, 1 },
                 new float [] { 3, 2, 1 },


               new float [] { 1, 278, 1 }, // 58


               new float [] { 3, 12, 2 }, // 59



               new float [] { 5, 1 }, // 60



            },


             new float [][]
            {

                new float [] { 3, 4, 2 },


                new float [] { 1, 1, 1 },

                new float [] { 2, 3, 1, 1 },

                new float [] { 2, 7, 1, 1 },

                new float [] { 1, 10, 1 },



                new float [] { 3, 1, 1 },

                new float [] { 2, 16, 1, 1 },

                new float [] { 2, 22, 1, 1 },

                 new float [] { 3, 5, 1 },


                new float [] { 2, 27, 1, 1 },

                new float [] { 2, 30, 1, 1 },

                new float [] { 3, 1, 1 },

                new float [] { 2, 33, 1, 1 },


                new float [] { 3, 1, 1 },

                new float [] { 2, 35, 1, 1 },

                new float [] { 1, 40, 1 },

                 new float [] { 1, 48, 1 },

                new float [] { 3, 1, 1 },


                 new float [] { 2, 56, 1, 1 },

                new float [] { 2, 60, 1, 1 },

                new float [] { 2, 64, 1, 1 },

                new float [] { 2, 73, 1, 1 },

                new float [] { 2, 76, 1, 1 },

                  new float [] { 2, 80, 1, 1 },



            }





        };



    }
    
    
    

    float[][][] points;


    int st = 1;

    public int runw = 0;

    public int pLevel = 0;

    public int pNext = 0;






  /** Documentation - UpdateGameRun 
  
      UpdateGameRun is an automatic game run with states 
      as run, jump and stop at different positions from an array
     
  
  */



    public void UpdateGameRun()
    {





        if (runw == 1)
        {


            if (points[pLevel][pNext][0] == 1) // run state
            {

                float xPoint = points[pLevel][pNext][1];

                float pState = points[pLevel][pNext][2];


                if (maincamera.transform.localPosition.x < xPoint && pState == 1)
                {
                    PlayerRightDown();

                    points[pLevel][pNext][2] = 0;

                }
                else if (maincamera.transform.localPosition.x >= xPoint || signshow == 1 || finishg == 1)
                {
                    PlayerRightUp();

                    points[pLevel][pNext][0] = 0;


                    pNext = pNext < (points[pLevel].Length - 1) ? pNext + 1 : pNext;
                }


            }

            if (points[pLevel][pNext][0] == 2) // run and jump
            {
                float xPoint = points[pLevel][pNext][1];

                float pJump = points[pLevel][pNext][2];

                float pState = points[pLevel][pNext][3];


                if (pJump == 1)
                {

                    PlayerJumpDown(); PlayerJumpUp();

                    points[pLevel][pNext][2] = 4;
                }

                /*  if (pJump == 2)
                  {

                      PlayerJumpDown(); PlayerJumpUp();

                      points[pLevel][pNext][2] = 5;
                  }*/



                if (maincamera.transform.localPosition.x < xPoint && pState == 1)
                {
                    PlayerRightDown();

                    points[pLevel][pNext][3] = 0;
                }

                else if (maincamera.transform.localPosition.x >= xPoint)
                {
                    PlayerRightUp();

                    // player.GetComponent<Rigidbody2D>().AddForce(Vector3.left * (0));

                    //   PlayerLeftDown();
                    //   PlayerLeftUp();

                    if (PlayerMove.instance.isGrounded && points[pLevel][pNext][2] == 4)
                    {
                        points[pLevel][pNext][0] = 0;

                        pNext = pNext < (points[pLevel].Length - 1) ? pNext + 1 : pNext;

                    }

                    /* else if (PlayerMove.instance.IsFalling && points[pLevel][pNext][2] == 5 )
                     {
                         points[pLevel][pNext][0] = 0;

                         pNext = pNext == (points[pLevel].Length - 1) ? pNext : pNext + 1;


                     }*/


                }


            }

            if (points[pLevel][pNext][0] == 3) // stop
            {

                float pTime = points[pLevel][pNext][1];

                float pFreeze = points[pLevel][pNext][2];


                if (pFreeze == 1)
                {


                    player.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;


                    points[pLevel][pNext][2] = rtime;
                }
                else if (pFreeze == 2)
                {
                    points[pLevel][pNext][2] = rtime;

                    //  Debug.Log("Freeze Run");

                }


                if (rtime == points[pLevel][pNext][2] + pTime)
                {

                    points[pLevel][pNext][0] = 0;

                    pNext = pNext < (points[pLevel].Length - 1) ? pNext + 1 : pNext;
                }



            }




            if (points[pLevel][pNext][0] == 4) // UIAction
            {

                float pSign = points[pLevel][pNext][1];

                if (pSign == 1)
                {

                    UIAction();

                    points[pLevel][pNext][0] = 0;


                    pNext = pNext < (points[pLevel].Length - 1) ? pNext + 1 : pNext;
                }


            }


            if (points[pLevel][pNext][0] == 5) // next level
            {

                float pNextLevel = points[pLevel][pNext][1];

                if (pNextLevel == 1)
                {

                    //  Debug.Log("Next Level Run");

                    points[pLevel][pNext][1] = 0;

                    points[pLevel][pNext][0] = 0;



                    pLevel++;

                    pNext = 0;


                    NextLevel();

                    //  pNext = pNext == (points[pLevel].Length - 1) ? pNext : pNext + 1;
                }


            }





            /*

            if (player.transform.localPosition.x > 25 && st == 1)
            {
                PlayerRightDown();

                PlayerJumpDown(); PlayerJumpUp();


                st = 2;
            }

            if (player.transform.localPosition.x > 38 && st == 2)
            {
                PlayerJumpDown(); PlayerJumpUp(); PlayerRightDown();

                st = 3;
            }


            if (player.transform.localPosition.x > 50 && st == 3)
            {
                PlayerJumpDown(); PlayerJumpUp(); PlayerRightDown();

                st = 4;
            }

            if (player.transform.localPosition.x > 63 && st == 4)
            {
                PlayerJumpDown(); PlayerJumpUp(); PlayerRightDown();

                st = 5;
            }

            if (player.transform.localPosition.x > 80 && st == 5)
            {
                PlayerJumpDown(); PlayerJumpUp(); PlayerRightDown();

                st = 6;
            }
            if (player.transform.localPosition.x > 86 && st == 6)
            {
                PlayerJumpDown(); PlayerJumpUp(); PlayerRightDown();

                st = 7;
            }
            if (player.transform.localPosition.x > 92 && st == 7)
            {
                PlayerJumpDown(); PlayerJumpUp(); PlayerRightDown();

                st = 8;
            }

            if (player.transform.localPosition.x > 105 && st == 8)
            {
                PlayerJumpDown(); PlayerJumpUp(); PlayerRightDown();

                st = 9;
            }


            if (player.transform.localPosition.x > 135 && st == 9)
            {
                PlayerJumpDown(); PlayerJumpUp(); PlayerRightDown();

                st = 10;
            }
            */



        }


    }
















