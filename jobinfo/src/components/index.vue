<template>
  <div class="hello">
    <!-- 返回顶部按钮 -->
    <transition name="van-slide-right">
      <van-button
        type="default"
        icon="arrow-up"
        round
        color="rgb(125,125,125)"
        v-show="flag_scroll"
        class="backTop"
        @click="backTop"
        style="opacity:0.60;"
      />
    </transition>
    <!-- 吸顶 -->
    <van-sticky>
      <!-- 导航栏 -->
      <van-nav-bar title="招聘公告" class="cbar" />
    </van-sticky>
    <!-- 搜索框 -->
    <van-search placeholder="请输入搜索关键词" input-align="center" />
    <!-- 列表 -->
    <van-pull-refresh v-model="refreshing" @refresh="onRefresh">
      <van-list v-model="loading" :finished="finished" finished-text="没有更多了" @load="onLoad">
        <van-cell
          :to="'/info?id='+item.title"
          v-for="(item,i) in list"
          :key="i"
          style="height:5.5rem;"
        >
          <!-- <van-image
            width="10rem"
            height="10rem"
            fit="contain"
            :src="(item.image)"
          />-->
          <div class="left">
            <!-- <van-image
              round
              width="3.5rem"
              height="3.5rem"
              fit="cover"
              src=""
            /> -->
            <img src="../assets/公司.png" style="width:3rem;height:3rem;"  alt="">
          </div>
          <div class="right">
            <div class="custom-title">
              <div class="van-ellipsis">中兴通讯全国中高职线上面试启动啦！</div>
            </div>
            <div class="city">湖北省|武汉市</div>
            <div class="co">武汉xxxx有限公司</div>
            <div class="date">2020-03-12</div>
          </div>
        </van-cell>
      </van-list>
    </van-pull-refresh>

    <!-- 防止内容被tabbar遮挡 -->
    <div style="height: 5rem;"></div>
    <!-- <Tabbar></Tabbar> -->
  </div>
</template>

<script>
export default {
  name: "index",
  data() {
    return {
      msg: "",
      list: [],
      loading: false,
      finished: false,
      refreshing: false,
      flag_scroll: ""
    };
  },
  methods: {
    onLoad() {
      // 异步更新数据
      // setTimeout 仅做示例，真实场景中一般为 ajax 请求

      if (this.refreshing) {
        this.list = [];
        this.refreshing = false;
      }

      this.axios
        .post("https://api.apiopen.top/getWangYiNews", {
          page: 1,
          count: 5
        })
        .then(m => {
          m.data.result.forEach(element => {
            this.list.push(element);
          });

          // alert(this.msg)
        })
        .catch(function(error) {
          console.log(error);
        });
      // 加载状态结束
      this.loading = false;

      // 数据全部加载完成
      if (this.list.length >= 40) {
        this.finished = true;
      }
    },
    onRefresh() {
      // 清空列表数据
      this.finished = false;

      // 重新加载数据
      // 将 loading 设置为 true，表示处于加载状态
      this.loading = true;
      this.onLoad();
    },
    backTop() {
      // 返回顶部
      // document.body.scrollTop = 0;
      document.documentElement.scrollTop = 0;
    },
    handleScroll(env) {
      //监听Scroll，显示或隐藏返回顶部按钮
      let scrollTop = document.documentElement.scrollTop;
      if (scrollTop > 100) {
        this.flag_scroll = true;
      } else {
        this.flag_scroll = false;
      }
    }
  },
  mounted() {
    window.addEventListener("scroll", this.handleScroll, true);
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.custom-title {
  font-weight: bold;
  font-size: 16px;
}
.date {
  right: 0.1rem;
  top: 1.5rem;

  position: absolute;
}
.city,
.co {
  font-size: 12px;
  color: rgb(120, 120, 120);
}
.co {
  line-height: 10px;
}
.left {
  margin-right: 1rem;
  position: absolute;
}
.right {
  padding-left: 4rem;
}
.backTop {
  position: fixed;
  right: 2rem;
  bottom: 6rem;
  z-index: 6;
}
</style>
