<template>
  <div class="hello">
    <van-sticky>
      <van-nav-bar title="更多信息" class="cbar" />
    </van-sticky>

    <van-swipe class="my-swipe" :autoplay="1500" indicator-color="white" >
      <van-swipe-item class="bg1"></van-swipe-item>
      <van-swipe-item class="bg2"></van-swipe-item>
      <van-swipe-item class="bg3"></van-swipe-item>
    </van-swipe>
  </div>
</template>

<script>
import Vue from "vue";
import { Image } from "vant";

Vue.use(Image);
export default {
  name: "more",
  data() {
    return {
      msg: [],
      images: ["../assets/2.jpg", "../assets/3.jpg", "../assets/1.jpg"]
    };
  },
  mounted() {
    // this.axios
    //   .post("https://api.apiopen.top/getWangYiNews", {
    //     page: 1,
    //     count: 5
    //   })
    //   .then(m => {
    //     this.msg = m.data.result;
    //     // alert(this.msg)
    //   })
    //   .catch(function(error) {
    //     console.log(error);
    //   });
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.my-swipe {
  color: #fff;
  width: 100%;
  height: 80%;
  text-align: center;
  position: absolute;
}
.bg1 {
  background-position: 0;
  height: 100%;
  background-image: url('../assets/2.jpg');
}
.bg2{
  background-position: 0;
  height: 100%;
  background-image: url('../assets/1.jpg');
}
.bg3 {
  background-position: 0;
  /* background-size: 100%; */
  height: 100%;
  background-repeat: no-repeat;
  background-image: url('../assets/3.jpg');
}
</style>
