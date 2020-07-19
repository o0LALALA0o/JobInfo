<template>
  <div class="Tabbar">
    <van-tabbar v-model="active">
      <van-tabbar-item v-for="(n,i) in tabbars" :to="(n.name)" :key=i :icon="(n.icon)">{{n.title}}</van-tabbar-item>
    </van-tabbar>
  </div>
</template>

<script>
export default {
  name: "Tabbar",
  data() {
    return {
      msg: "",
      active: 0,
      tabbars:[
            {
                name: "/",
                title: "招聘公告",
                icon:"wap-nav"
            },
            {
                name: "/more",
                title: "更多",
                icon:"more"
            }
      ]
    };
  },
  mounted() {
     
  },
  created() {
     this.msg=this.$route.name;
      if (this.$route.name == "index") {
      this.active = 0;
    } else if (this.$route.name == "more") {
      this.active = 1;
    }
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>