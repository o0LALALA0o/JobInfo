<template>
  <div class="box">
    <!-- 吸顶 -->
    <van-sticky>
      <van-nav-bar title="招聘详情" left-text="返回" left-arrow @click-left="onClickLeft" />
    </van-sticky>

    <div class="topD">
      <div class="custom-title">中兴通讯全国中高职线上面试启动啦！</div>
      <div class="city">湖北省|武汉市</div>
      <div class="date">发布时间:2020-03-12</div>
      <div style="height:1px; margin-top:-1px;clear: both;overflow:hidden;"></div>
    </div>

    <van-divider :style="{ color: 'rgb(30,30,30)', padding: '0 16px' }">
      <b>职位描述</b>
    </van-divider>

    <div class="cenD">
      各位同学，中兴通讯全国中高职线上面试启动啦！
      现阶段广东深圳、广东河源、湖南长沙、陕西西安、江苏南京智能制造基地可供选择，需要找工作的可以扫码如下二维码填写信息，公司会安排专员和你联系，切记只限于已毕业和未毕业的中专、大专毕业生。
      <br/><br/>
      <img src="../assets/r1.jpg" class="iImg" alt />
      <img src="../assets/r2.jpg" class="iImg" alt />
      <!-- <img v-for="(img,i)  in imageList" :key="i" v-lazy="img" /> -->
    </div>
    
  </div>
</template>
<script>
export default {
  name: "info",
  data() {
    return {
      msg: "123",
      imageList: ["../assets/r1.jpg", "https://img.yzcdn.cn/vant/apple-2.jpg"]
    };
  },
  created() {
    //   获取传过来的值
    this.msg = this.$route.query.id;
  },
  methods: {
    onClickLeft() {
      //   Toast("返回");
      //   this.$router.push({path:'/index'})
      history.back(); //:直接返回当前页的上一页，数据全部消息，是个新页面
    }
  }
};
</script>

<style scoped>
.custom-title {
  font-weight: bold;
  font-size: 16px;
}
.city,
.co,
.date {
  font-size: 14px;
}
.topD {
  padding-bottom: 0.5rem;
  padding-top: 0.5rem;
  padding-left: 1rem;
  padding-right: 1rem;
  border-bottom-width: 1rem;
  border-bottom-style: solid;
  border-bottom-color: rgb(245, 245, 245);
  
}
.cenD {
  padding-left: 1rem;
  padding-right: 1rem;
}
.iImg {
  width: 100%;
}
</style>