jQuery(function ($) {
  // Dropdown menu
  $('.sidebar-dropdown > a').click(function () {
    $('.sidebar-submenu').slideUp(200);
    if ($(this).parent().hasClass('active')) {
      $('.sidebar-dropdown').removeClass('active');
      $(this).parent().removeClass('active');
    } else {
      $('.sidebar-dropdown').removeClass('active');
      $(this).next('.sidebar-submenu').slideDown(200);
      $(this).parent().addClass('active');
    }
  });

  //toggle sidebar
  $('#toggle-sidebar').click(function () {
    $('.page-wrapper').toggleClass('toggled');
  });

  // bind hover if pinned is initially enabled
  if ($('.page-wrapper').hasClass('pinned')) {
    $('#sidebar').hover(
      function () {
        console.log('mouseenter');
        $('.page-wrapper').addClass('sidebar-hovered');
      },
      function () {
        console.log('mouseout');
        $('.page-wrapper').removeClass('sidebar-hovered');
      }
    );
  }

  //Pin sidebar
  $('#pin-sidebar').click(function () {
    if ($('.page-wrapper').hasClass('pinned')) {
      // unpin sidebar when hovered
      $('.page-wrapper').removeClass('pinned');
      $('#sidebar').unbind('hover');
    } else {
      $('.page-wrapper').addClass('pinned');
      $('#sidebar').hover(
        function () {
          console.log('mouseenter');
          $('.page-wrapper').addClass('sidebar-hovered');
        },
        function () {
          console.log('mouseout');
          $('.page-wrapper').removeClass('sidebar-hovered');
        }
      );
    }
  });

  //toggle sidebar overlay
  $('#overlay').click(function () {
    $('.page-wrapper').toggleClass('toggled');
  });

  //switch between themes
  var themes =
    'default-theme legacy-theme chiller-theme ice-theme cool-theme light-theme';
  $('[data-theme]').click(function () {
    $('[data-theme]').removeClass('selected');
    $(this).addClass('selected');
    $('.page-wrapper').removeClass(themes);
    $('.page-wrapper').addClass($(this).attr('data-theme'));
  });

  // switch between background images
  var bgs = 'bg1 bg2 bg3 bg4';
  $('[data-bg]').click(function () {
    $('[data-bg]').removeClass('selected');
    $(this).addClass('selected');
    $('.page-wrapper').removeClass(bgs);
    $('.page-wrapper').addClass($(this).attr('data-bg'));
  });

  // toggle background image
  $('#toggle-bg').change(function (e) {
    e.preventDefault();
    $('.page-wrapper').toggleClass('sidebar-bg');
  });

  // toggle border radius
  $('#toggle-border-radius').change(function (e) {
    e.preventDefault();
    $('.page-wrapper').toggleClass('boder-radius-on');
  });

  //custom scroll bar is only used on desktop
  if (
    !/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(
      navigator.userAgent
    )
  ) {
    $('.sidebar-content').mCustomScrollbar({
      axis: 'y',
      autoHideScrollbar: true,
      scrollInertia: 300,
    });
    $('.sidebar-content').addClass('desktop');
  }


   
});
jQuery.expr[':'].casecontains = (a, b, c) => jQuery(a).text().toUpperCase().indexOf(c[3].toUpperCase()) >= 0;

$('.search-menu').on('keyup', function () {
    var input = $('.search-menu').val();
    console.log('input: ' + input);
    if (input.length != 0) {
        // first hide the div #link-content lists from view
        $('#link-content li').hide();
        // but secretly unhide the collapsed links
        // using .show, so the nested uls can be viewed
        $('.sidebar-submenu ul li').show();
        // then filter in the matching links only
        $('.sidebar-submenu ul li:casecontains("' + input + '")').show();
    } else {
        // secretly unhide the collapsed links
        $('.sidebar-submenu ul li').hide();
        // if search is empty, show the div and reset columns
        $('#link-content li').show();
    }
});