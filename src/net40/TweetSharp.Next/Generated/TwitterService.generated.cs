﻿using System;
using System.Collections.Generic;
using System.IO;
using Hammock;
using Hammock.Web;

namespace TweetSharp
{
#region Interface
	public partial interface ITwitterService
	{
#if !SILVERLIGHT
		#region Sequential Methods
		TwitterUser VerifyCredentials();	

		TwitterRateLimitStatus GetRateLimitStatus();	

		TwitterError EndSession();	

		TwitterUser UpdateDeliveryDevice(TwitterDeliveryDevice device);	

		TwitterUser UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, string sidebarBorderColor);	

		TwitterUser UpdateProfileColors(string backgroundColor);	

		TwitterUser UpdateProfileColors(string backgroundColor, string textColor);	

		TwitterUser UpdateProfileColors(string backgroundColor, string textColor, string linkColor);	

		TwitterUser UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor);	

		TwitterUser UpdateProfileImage(string path);	

		TwitterUser UpdateProfileBackgroundImage(string path);	

		TwitterUser UpdateProfile(string name, string description, string email, string url, string location);	

		TwitterConfiguration GetConfiguration();	

		TwitterUser BlockUser(int userId);	

		TwitterUser BlockUser(string userScreenName);	

		TwitterUser UnblockUser(int userId);	

		TwitterUser UnblockUser(string userScreenName);	

		TwitterUser VerifyBlocking(int userId);	

		TwitterUser VerifyBlocking(string userScreenName);	

		IEnumerable<TwitterUser> ListBlockedUsers();	

		IEnumerable<TwitterUser> ListBlockedUsers(int page);	

		IEnumerable<int> ListBlockedUserIds();	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceived();	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceived(int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceived(int page, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedSince(long sinceId);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedSince(long sinceId, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedSince(long sinceId, int page, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedBefore(long maxId);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedBefore(long maxId, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedBefore(long maxId, int page, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSent();	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSent(int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSent(int page, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSentSince(long sinceId);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSentSince(long sinceId, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSentSince(long sinceId, int page, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSentBefore(long maxId);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSentBefore(long maxId, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSentBefore(long maxId, int page, int count);	

		TwitterDirectMessage DeleteDirectMessage(long id);	

		TwitterDirectMessage DeleteDirectMessage(int id);	

		TwitterDirectMessage SendDirectMessage(int userId, string text);	

		TwitterDirectMessage SendDirectMessage(string screenName, string text);	

		IEnumerable<TwitterStatus> ListFavoriteTweets();	

		IEnumerable<TwitterStatus> ListFavoriteTweets(int page);	

		IEnumerable<TwitterStatus> ListFavoriteTweets(int page, int count);	

		IEnumerable<TwitterStatus> ListFavoriteTweetsFor(int userId);	

		IEnumerable<TwitterStatus> ListFavoriteTweetsFor(int userId, int page);	

		IEnumerable<TwitterStatus> ListFavoriteTweetsFor(int userId, int page, int count);	

		IEnumerable<TwitterStatus> ListFavoriteTweetsFor(string userScreenName);	

		IEnumerable<TwitterStatus> ListFavoriteTweetsFor(string userScreenName, int page);	

		IEnumerable<TwitterStatus> ListFavoriteTweetsFor(string userScreenName, int page, int count);	

		TwitterStatus FavoriteTweet(long id);	

		TwitterStatus UnfavoriteTweet(long id);	

		TwitterCursorList<int> ListFriendIdsOf(string screenName, long cursor);	

		TwitterCursorList<int> ListFriendIdsOf(int userId, long cursor);	

		TwitterCursorList<int> ListFollowerIdsOf(int userId, long cursor);	

		TwitterCursorList<int> ListFollowerIdsOf(string screenName, long cursor);	

		TwitterUser FollowUser(int userId);	

		TwitterUser FollowUser(string screenName);	

		TwitterUser UnfollowUser(string screenName);	

		TwitterUser UnfollowUser(int userId);	

		TwitterCursorList<int> GetIncomingFriendRequests();	

		TwitterCursorList<int> GetIncomingFriendRequests(long cursor);	

		TwitterCursorList<int> GetOutgoingFriendRequests();	

		TwitterCursorList<int> GetOutgoingFriendRequests(long cursor);	

		TwitterFriendship GetFriendshipInfo(string sourceScreenName, string targetScreenName);	

		TwitterFriendship GetFriendshipInfo(int sourceId, int targetId);	

		TwitterList CreateList(string name);	

		TwitterList CreateList(string name, string description);	

		TwitterList CreateList(string name, string description, string mode);	

		TwitterList UpdateList(long listId, string name);	

		TwitterList UpdateList(long listId, string name, string description);	

		TwitterList UpdateList(long listId, string name, string description, string mode);	

		TwitterList UpdateList(string slug, int ownerId, string name);	

		TwitterList UpdateList(string slug, int ownerId, string name, string description);	

		TwitterList UpdateList(string slug, int ownerId, string name, string description, string mode);	

		TwitterList UpdateList(string slug, string ownerScreenName, string name);	

		TwitterList UpdateList(string slug, string ownerScreenName, string name, string description);	

		TwitterList UpdateList(string slug, string ownerScreenName, string name, string description, string mode);	

		TwitterCursorList<TwitterList> ListLists();	

		TwitterCursorList<TwitterList> ListLists(long cursor);	

		TwitterCursorList<TwitterList> ListListsFor(int userId);	

		TwitterCursorList<TwitterList> ListListsFor(int userId, long cursor);	

		TwitterCursorList<TwitterList> ListListsFor(string screenName);	

		TwitterCursorList<TwitterList> ListListsFor(string screenName, long cursor);	

		TwitterList GetList(int userId);	

		TwitterList GetList(string slug, int ownerId);	

		TwitterList GetList(string slug, string ownerScreenName);	

		TwitterList DeleteList(long listId);	

		TwitterList DeleteList(string slug, int ownerId);	

		TwitterList DeleteList(string slug, string ownerScreenName);	

		IEnumerable<TwitterStatus> ListTweetsOnList(long listId);	

		IEnumerable<TwitterStatus> ListTweetsOnList(long listId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnList(long listId, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnList(long listId, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnList(long listId, int page, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnList(long listId, int page, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnList(string slug, int ownerId);	

		IEnumerable<TwitterStatus> ListTweetsOnList(string slug, int ownerId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnList(string slug, int ownerId, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnList(string slug, int ownerId, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnList(string slug, int ownerId, int page, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnList(string slug, int ownerId, int page, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnList(string slug, string ownerScreenName);	

		IEnumerable<TwitterStatus> ListTweetsOnList(string slug, string ownerScreenName, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnList(string slug, string ownerScreenName, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnList(string slug, string ownerScreenName, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnList(string slug, string ownerScreenName, int page, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnList(string slug, string ownerScreenName, int page, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(long listId, long sinceId);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(long listId, long sinceId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(long listId, long sinceId, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(long listId, long sinceId, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(long listId, long sinceId, int page, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(long listId, int page, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, int ownerId, long sinceId);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, int ownerId, long sinceId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, int ownerId, long sinceId, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, int ownerId, long sinceId, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, int ownerId, long sinceId, int page, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, int ownerId, long sinceId, int page, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int page, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int page, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(long listId, long maxId);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(long listId, long maxId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(long listId, long maxId, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(long listId, long maxId, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(long listId, long maxId, int page, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(long listId, int page, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, int ownerId, long maxId);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, int ownerId, long maxId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, int ownerId, long maxId, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, int ownerId, long maxId, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, int ownerId, long maxId, int page, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, int ownerId, long maxId, int page, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int perPage, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int page, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int page, int perPage, bool includeRts);	

		TwitterCursorList<TwitterList> ListListMemberships();	

		TwitterCursorList<TwitterList> ListListMembershipsFor(int userId);	

		TwitterCursorList<TwitterList> ListListMembershipsFor(int userId, long cursor);	

		TwitterCursorList<TwitterList> ListListMembershipsFor(int userId, bool filterToOwnedLists);	

		TwitterCursorList<TwitterList> ListListMembershipsFor(int userId, bool filterToOwnedLists, long cursor);	

		TwitterCursorList<TwitterList> ListListMembershipsFor(string screenName);	

		TwitterCursorList<TwitterList> ListListMembershipsFor(string screenName, long cursor);	

		TwitterCursorList<TwitterList> ListListMembershipsFor(string screenName, bool filterToOwnedLists);	

		TwitterCursorList<TwitterList> ListListMembershipsFor(string screenName, bool filterToOwnedLists, long cursor);	

		TwitterCursorList<TwitterUser> ListListMembers(long listId);	

		TwitterCursorList<TwitterUser> ListListMembers(long listId, long cursor);	

		TwitterCursorList<TwitterUser> ListListMembers(long listId, bool skipStatus);	

		TwitterCursorList<TwitterUser> ListListMembers(long listId, bool skipStatus, long cursor);	

		TwitterCursorList<TwitterUser> ListListMembers(string slug, int ownerId);	

		TwitterCursorList<TwitterUser> ListListMembers(string slug, int ownerId, long cursor);	

		TwitterCursorList<TwitterUser> ListListMembers(string slug, string ownerScreenName, bool skipStatus);	

		TwitterCursorList<TwitterUser> ListListMembers(string slug, string ownerScreenName, bool skipStatus, long cursor);	

		TwitterUser AddListMember(long listId, int userId);	

		TwitterUser AddListMember(string slug, int ownerId, int userId);	

		TwitterUser AddListMember(string slug, string ownerScreenName, int userId);	

		TwitterUser AddListMember(long listId, string screenName);	

		TwitterUser AddListMember(string slug, int ownerId, string screenName);	

		TwitterUser AddListMember(string slug, string ownerScreenName, string screenName);	

		TwitterUser RemoveListMember(long listId, int userId);	

		TwitterUser RemoveListMember(string slug, int ownerId, int userId);	

		TwitterUser RemoveListMember(string slug, string ownerScreenName, int userId);	

		TwitterUser RemoveListMember(long listId, string screenName);	

		TwitterUser RemoveListMember(string slug, int ownerId, string screenName);	

		TwitterUser RemoveListMember(string slug, string ownerScreenName, string screenName);	

		TwitterCursorList<TwitterList> AddListMembers(long listId, string userId);	

		TwitterCursorList<TwitterList> AddListMembersByScreenName(long listId, string screenName);	

		TwitterCursorList<TwitterList> AddListMembers(string slug, int ownerId, string userId);	

		TwitterCursorList<TwitterList> AddListMembersByScreenName(string slug, int ownerId, string screenName);	

		TwitterCursorList<TwitterList> AddListMembers(string slug, string ownerScreenName, string userId);	

		TwitterCursorList<TwitterList> AddListMembersByScreenName(string slug, string ownerScreenName, string screenName);	

		TwitterUser VerifyListMembership(long listId, int userId);	

		TwitterUser VerifyListMembership(long listId, int userId, bool skipStatus);	

		TwitterUser VerifyListMembership(long listId, string screenName);	

		TwitterUser VerifyListMembership(long listId, string screenName, bool skipStatus);	

		TwitterUser VerifyListMembership(string slug, int ownerId, int userId);	

		TwitterUser VerifyListMembership(string slug, int ownerId, int userId, bool skipStatus);	

		TwitterUser VerifyListMembership(string slug, int ownerId, string screenName);	

		TwitterUser VerifyListMembership(string slug, int ownerId, string screenName, bool skipStatus);	

		TwitterUser VerifyListMembership(string slug, string ownerScreenName, int userId);	

		TwitterUser VerifyListMembership(string slug, string ownerScreenName, int userId, bool skipStatus);	

		TwitterUser VerifyListMembership(string slug, string ownerScreenName, string screenName);	

		TwitterUser VerifyListMembership(string slug, string ownerScreenName, string screenName, bool skipStatus);	

		IEnumerable<TwitterList> ListListSubscriptions();	

		IEnumerable<TwitterList> ListListSubscriptionsFor(int userId);	

		IEnumerable<TwitterList> ListListSubscriptionsFor(string screenName);	

		TwitterCursorList<TwitterUser> ListListSubscribers(long listId);	

		TwitterCursorList<TwitterUser> ListListSubscribers(long listId, long cursor);	

		TwitterCursorList<TwitterUser> ListListSubscribers(long listId, bool skipStatus);	

		TwitterCursorList<TwitterUser> ListListSubscribers(long listId, bool skipStatus, long cursor);	

		TwitterCursorList<TwitterUser> ListListSubscribers(string slug, int ownerId);	

		TwitterCursorList<TwitterUser> ListListSubscribers(string slug, int ownerId, long cursor);	

		TwitterCursorList<TwitterUser> ListListSubscribers(string slug, string ownerScreenName, bool skipStatus);	

		TwitterCursorList<TwitterUser> ListListSubscribers(string slug, string ownerScreenName, bool skipStatus, long cursor);	

		TwitterUser FollowList(long listId);	

		TwitterUser FollowList(string slug, int ownerId);	

		TwitterUser FollowList(string slug, string ownerScreenName);	

		TwitterUser UnfollowList(long listId);	

		TwitterUser UnfollowList(string slug, int ownerId);	

		TwitterUser UnfollowList(string slug, string ownerScreenName);	

		TwitterUser VerifyListSubscription(long listId, int userId);	

		TwitterUser VerifyListSubscription(long listId, int userId, bool skipStatus);	

		TwitterUser VerifyListSubscription(long listId, string screenName);	

		TwitterUser VerifyListSubscription(long listId, string screenName, bool skipStatus);	

		TwitterUser VerifyListSubscription(string slug, int ownerId, int userId);	

		TwitterUser VerifyListSubscription(string slug, int ownerId, int userId, bool skipStatus);	

		TwitterUser VerifyListSubscription(string slug, int ownerId, string screenName);	

		TwitterUser VerifyListSubscription(string slug, int ownerId, string screenName, bool skipStatus);	

		TwitterUser VerifyListSubscription(string slug, string ownerScreenName, int userId);	

		TwitterUser VerifyListSubscription(string slug, string ownerScreenName, int userId, bool skipStatus);	

		TwitterUser VerifyListSubscription(string slug, string ownerScreenName, string screenName);	

		TwitterUser VerifyListSubscription(string slug, string ownerScreenName, string screenName, bool skipStatus);	

		TwitterUser FollowUserNotifications(string screenName);	

		TwitterUser FollowUserNotifications(int userId);	

		TwitterUser UnfollowUserNotifications(int userId);	

		TwitterUser UnfollowUserNotifications(string userScreenName);	

		IEnumerable<TwitterSavedSearch> ListSavedSearches();	

		TwitterSavedSearch GetSavedSearch(long id);	

		TwitterSavedSearch CreateSavedSearch(string query);	

		TwitterSavedSearch DeleteSavedSearch(long id);	

		TwitterSearchResult Search(string q);	

		TwitterSearchResult Search(string q, TwitterSearchResultType resultType);	

		TwitterSearchResult Search(string q, int rpp);	

		TwitterSearchResult Search(string q, int rpp, TwitterSearchResultType resultType);	

		TwitterSearchResult Search(string q, int page, int rpp);	

		TwitterSearchResult Search(string q, int page, int rpp, TwitterSearchResultType resultType);	

		TwitterSearchResult SearchSince(long since_id, string q);	

		TwitterSearchResult SearchSince(long since_id, string q, TwitterSearchResultType resultType);	

		TwitterSearchResult SearchSince(long since_id, string q, int rpp);	

		TwitterSearchResult SearchSince(long since_id, string q, int rpp, TwitterSearchResultType resultType);	

		TwitterSearchResult SearchSince(long since_id, string q, int page, int rpp);	

		TwitterSearchResult SearchSince(long since_id, string q, int page, int rpp, TwitterSearchResultType resultType);	

		TwitterSearchResult SearchBefore(long max_id, string q);	

		TwitterSearchResult SearchBefore(long max_id, string q, TwitterSearchResultType resultType);	

		TwitterSearchResult SearchBefore(long max_id, string q, int rpp);	

		TwitterSearchResult SearchBefore(long max_id, string q, int rpp, TwitterSearchResultType resultType);	

		TwitterSearchResult SearchBefore(long max_id, string q, int page, int rpp);	

		TwitterSearchResult SearchBefore(long max_id, string q, int page, int rpp, TwitterSearchResultType resultType);	

		TwitterUser ReportSpam(int userId);	

		TwitterUser ReportSpam(string userScreenName);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline();	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(int count);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(int page, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId, int page, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId, int page, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimeline();	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(int count);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(int page, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId, int page, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId, int page, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count, bool includeRts);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMe();	

		IEnumerable<TwitterStatus> ListTweetsMentioningMe(int count);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMe(int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMeSince(long sinceId);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMeSince(long sinceId, int count);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMeSince(long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMeBefore(long maxId);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMeBefore(long maxId, int count);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMeBefore(long maxId, int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsByMe();	

		IEnumerable<TwitterStatus> ListRetweetsByMe(int count);	

		IEnumerable<TwitterStatus> ListRetweetsByMe(int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsByMe(long sinceId);	

		IEnumerable<TwitterStatus> ListRetweetsByMeSince(long sinceId, int count);	

		IEnumerable<TwitterStatus> ListRetweetsByMeSince(long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsByMeBefore(long maxId);	

		IEnumerable<TwitterStatus> ListRetweetsByMeBefore(long maxId, int count);	

		IEnumerable<TwitterStatus> ListRetweetsByMeBefore(long maxId, int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsToMe();	

		IEnumerable<TwitterStatus> ListRetweetsToMe(int count);	

		IEnumerable<TwitterStatus> ListRetweetsToMe(int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsToMeSince(long sinceId);	

		IEnumerable<TwitterStatus> ListRetweetsToMeSince(long sinceId, int count);	

		IEnumerable<TwitterStatus> ListRetweetsToMeSince(long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsToMeBefore(long maxId);	

		IEnumerable<TwitterStatus> ListRetweetsToMeBefore(long maxId, int count);	

		IEnumerable<TwitterStatus> ListRetweetsToMeBefore(long maxId, int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweets();	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweets(int count);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweets(int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweets(long sinceId);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsSince(long sinceId, int count);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsSince(long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsSince(long maxId);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsBefore(long maxId, int count);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsBefore(long maxId, int page, int count);	

		TwitterCurrentTrends ListCurrentTrends(int woeid);	

		TwitterCurrentTrends ListCurrentTrends(string exclude, int woeid);	

		TwitterTrends ListDailyTrends();	

		TwitterTrends ListDailyTrends(DateTime date);	

		TwitterTrends ListDailyTrends(string exclude);	

		TwitterTrends ListDailyTrends(DateTime date, string exclude);	

		TwitterTrends ListWeeklyTrends();	

		TwitterTrends ListWeeklyTrends(DateTime date);	

		TwitterTrends ListWeeklyTrends(string exclude);	

		TwitterTrends ListWeeklyTrends(DateTime date, string exclude);	

		IEnumerable<WhereOnEarthLocation> ListAvailableTrendsLocations();	

		IEnumerable<WhereOnEarthLocation> ListAvailableTrendsLocations(string lat);	

		IEnumerable<WhereOnEarthLocation> ListAvailableTrendsLocations(string lat, string @long);	

		TwitterLocalTrends ListLocalTrendsFor(long woeId);	

		TwitterStatus GetTweet(long id);	

		TwitterStatus SendTweet(string status);	

		TwitterStatus SendTweet(string status, string lat, string @long);	

		TwitterStatus SendTweet(string status, long inReplyToStatusId);	

		TwitterStatus SendTweet(string status, long inReplyToStatusId, string lat, string @long);	

		TwitterStatus DeleteTweet(long id);	

		TwitterStatus Retweet(long id);	

		IEnumerable<TwitterStatus> Retweets(long id);	

		IEnumerable<TwitterStatus> Retweets(long id, int count);	

		IEnumerable<TwitterUser> ListUsersWhoRetweeted(long id);	

		IEnumerable<TwitterUser> ListUsersWhoRetweeted(long id, int count);	

		IEnumerable<int> ListUserIdsWhoRetweeted(long id);	

		IEnumerable<int> ListUserIdsWhoRetweeted(long id, int count);	

		TwitterUser GetUserProfile();	

		TwitterUser GetUserProfileFor(string screenName);	

		TwitterUser GetUserProfileFor(int id);	

		IEnumerable<TwitterUser> SearchForUser(string q);	

		IEnumerable<TwitterUser> SearchForUser(string q, int perPage);	

		IEnumerable<TwitterUser> SearchForUser(string q, int page, int perPage);	

		IEnumerable<TwitterUser> ListUserProfilesFor(string userId);	

		byte[] GetProfileImageFor(string screenName);	

		byte[] GetProfileImageFor(string screenName, TwitterProfileImageSize size);	

		IEnumerable<TwitterUserSuggestions> ListSuggestedUserCategories();	

		TwitterUserSuggestions ListSuggestedUsers(string categorySlug);	

		#endregion
#endif

#if !WINDOWS_PHONE
		#region Asynchronous Methods (with IAsyncResult)
		IAsyncResult VerifyCredentials(Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult GetRateLimitStatus(Action<TwitterRateLimitStatus, TwitterResponse> action);		

		IAsyncResult EndSession(Action<TwitterError, TwitterResponse> action);		

		IAsyncResult UpdateDeliveryDevice(TwitterDeliveryDevice device, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, string sidebarBorderColor, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfileColors(string backgroundColor, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, string linkColor, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfileImage(string path, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfileBackgroundImage(string path, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfile(string name, string description, string email, string url, string location, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult GetConfiguration(Action<TwitterConfiguration, TwitterResponse> action);		

		IAsyncResult BlockUser(int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult BlockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnblockUser(int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnblockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyBlocking(int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyBlocking(string userScreenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult ListBlockedUsers(Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListBlockedUsers(int page, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListBlockedUserIds(Action<IEnumerable<int>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceived(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceived(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceived(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceivedSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceivedSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceivedSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceivedBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceivedBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceivedBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSent(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSent(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSent(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSentSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSentSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSentSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSentBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSentBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSentBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult DeleteDirectMessage(long id, Action<TwitterDirectMessage, TwitterResponse> action);		

		IAsyncResult DeleteDirectMessage(int id, Action<TwitterDirectMessage, TwitterResponse> action);		

		IAsyncResult SendDirectMessage(int userId, string text, Action<TwitterDirectMessage, TwitterResponse> action);		

		IAsyncResult SendDirectMessage(string screenName, string text, Action<TwitterDirectMessage, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweets(int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweetsFor(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweetsFor(int userId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweetsFor(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweetsFor(string userScreenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweetsFor(string userScreenName, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweetsFor(string userScreenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult FavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult UnfavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult ListFriendIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult ListFriendIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult ListFollowerIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult ListFollowerIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult FollowUser(int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult FollowUser(string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnfollowUser(string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnfollowUser(int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult GetIncomingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult GetIncomingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult GetOutgoingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult GetOutgoingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult GetFriendshipInfo(string sourceScreenName, string targetScreenName, Action<TwitterFriendship, TwitterResponse> action);		

		IAsyncResult GetFriendshipInfo(int sourceId, int targetId, Action<TwitterFriendship, TwitterResponse> action);		

		IAsyncResult CreateList(string name, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult CreateList(string name, string description, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult CreateList(string name, string description, string mode, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult UpdateList(long listId, string name, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult UpdateList(long listId, string name, string description, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult UpdateList(long listId, string name, string description, string mode, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult UpdateList(string slug, int ownerId, string name, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult UpdateList(string slug, int ownerId, string name, string description, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult UpdateList(string slug, int ownerId, string name, string description, string mode, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult UpdateList(string slug, string ownerScreenName, string name, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult UpdateList(string slug, string ownerScreenName, string name, string description, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult UpdateList(string slug, string ownerScreenName, string name, string description, string mode, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult ListLists(Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListLists(long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListsFor(int userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListsFor(int userId, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListsFor(string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListsFor(string screenName, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult GetList(int userId, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult GetList(string slug, int ownerId, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult GetList(string slug, string ownerScreenName, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult DeleteList(long listId, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult DeleteList(string slug, int ownerId, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult DeleteList(string slug, string ownerScreenName, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(long listId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(long listId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(long listId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(long listId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(long listId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(long listId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(string slug, int ownerId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(string slug, int ownerId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(string slug, int ownerId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(string slug, int ownerId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(string slug, int ownerId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(string slug, int ownerId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(string slug, string ownerScreenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(string slug, string ownerScreenName, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(string slug, string ownerScreenName, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(string slug, string ownerScreenName, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(string slug, string ownerScreenName, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(string slug, string ownerScreenName, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(long listId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(long listId, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(long listId, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(long listId, long sinceId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(long listId, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(long listId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(string slug, int ownerId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(string slug, int ownerId, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(string slug, int ownerId, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(string slug, int ownerId, long sinceId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(string slug, int ownerId, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(string slug, int ownerId, long sinceId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(long listId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(long listId, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(long listId, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(long listId, long maxId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(long listId, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(long listId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(string slug, int ownerId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(string slug, int ownerId, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(string slug, int ownerId, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(string slug, int ownerId, long maxId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(string slug, int ownerId, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(string slug, int ownerId, long maxId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListListMemberships(Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListMembershipsFor(int userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListMembershipsFor(int userId, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListMembershipsFor(int userId, bool filterToOwnedLists, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListMembershipsFor(int userId, bool filterToOwnedLists, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListMembershipsFor(string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListMembershipsFor(string screenName, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListMembershipsFor(string screenName, bool filterToOwnedLists, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListMembershipsFor(string screenName, bool filterToOwnedLists, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListMembers(long listId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListListMembers(long listId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListListMembers(long listId, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListListMembers(long listId, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListListMembers(string slug, int ownerId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListListMembers(string slug, int ownerId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListListMembers(string slug, string ownerScreenName, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListListMembers(string slug, string ownerScreenName, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult AddListMember(long listId, int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult AddListMember(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult AddListMember(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult AddListMember(long listId, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult AddListMember(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult AddListMember(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult RemoveListMember(long listId, int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult RemoveListMember(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult RemoveListMember(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult RemoveListMember(long listId, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult RemoveListMember(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult RemoveListMember(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult AddListMembers(long listId, string userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult AddListMembersByScreenName(long listId, string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult AddListMembers(string slug, int ownerId, string userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult AddListMembersByScreenName(string slug, int ownerId, string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult AddListMembers(string slug, string ownerScreenName, string userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult AddListMembersByScreenName(string slug, string ownerScreenName, string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult VerifyListMembership(long listId, int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListMembership(long listId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListMembership(long listId, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListMembership(long listId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListMembership(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListMembership(string slug, int ownerId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListMembership(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListMembership(string slug, int ownerId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListMembership(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListMembership(string slug, string ownerScreenName, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListMembership(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListMembership(string slug, string ownerScreenName, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult ListListSubscriptions(Action<IEnumerable<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListSubscriptionsFor(int userId, Action<IEnumerable<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListSubscriptionsFor(string screenName, Action<IEnumerable<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListSubscribers(long listId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListListSubscribers(long listId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListListSubscribers(long listId, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListListSubscribers(long listId, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListListSubscribers(string slug, int ownerId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListListSubscribers(string slug, int ownerId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListListSubscribers(string slug, string ownerScreenName, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListListSubscribers(string slug, string ownerScreenName, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult FollowList(long listId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult FollowList(string slug, int ownerId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult FollowList(string slug, string ownerScreenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnfollowList(long listId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnfollowList(string slug, int ownerId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnfollowList(string slug, string ownerScreenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListSubscription(long listId, int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListSubscription(long listId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListSubscription(long listId, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListSubscription(long listId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListSubscription(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListSubscription(string slug, int ownerId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListSubscription(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListSubscription(string slug, int ownerId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListSubscription(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListSubscription(string slug, string ownerScreenName, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListSubscription(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListSubscription(string slug, string ownerScreenName, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult FollowUserNotifications(string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult FollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnfollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnfollowUserNotifications(string userScreenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult ListSavedSearches(Action<IEnumerable<TwitterSavedSearch>, TwitterResponse> action);		

		IAsyncResult GetSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action);		

		IAsyncResult CreateSavedSearch(string query, Action<TwitterSavedSearch, TwitterResponse> action);		

		IAsyncResult DeleteSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action);		

		IAsyncResult Search(string q, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult Search(string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult Search(string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult Search(string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult Search(string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult Search(string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchSince(long since_id, string q, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchSince(long since_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchSince(long since_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchSince(long since_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchSince(long since_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchSince(long since_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchBefore(long max_id, string q, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchBefore(long max_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchBefore(long max_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchBefore(long max_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchBefore(long max_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchBefore(long max_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult ReportSpam(int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult ReportSpam(string userScreenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimeline(bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimeline(int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimeline(int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimeline(bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimeline(int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimeline(int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMe(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweets(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweets(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweetsSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweetsSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweetsSince(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweetsBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweetsBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListCurrentTrends(int woeid, Action<TwitterCurrentTrends, TwitterResponse> action);		

		IAsyncResult ListCurrentTrends(string exclude, int woeid, Action<TwitterCurrentTrends, TwitterResponse> action);		

		IAsyncResult ListDailyTrends(Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListDailyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListDailyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListDailyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListWeeklyTrends(Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListWeeklyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListWeeklyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListWeeklyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListAvailableTrendsLocations(Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action);		

		IAsyncResult ListAvailableTrendsLocations(string lat, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action);		

		IAsyncResult ListAvailableTrendsLocations(string lat, string @long, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action);		

		IAsyncResult ListLocalTrendsFor(long woeId, Action<TwitterLocalTrends, TwitterResponse> action);		

		IAsyncResult GetTweet(long id, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult SendTweet(string status, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult SendTweet(string status, string lat, string @long, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult SendTweet(string status, long inReplyToStatusId, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult SendTweet(string status, long inReplyToStatusId, string lat, string @long, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult DeleteTweet(long id, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult Retweet(long id, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult Retweets(long id, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult Retweets(long id, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListUsersWhoRetweeted(long id, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListUsersWhoRetweeted(long id, int count, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListUserIdsWhoRetweeted(long id, Action<IEnumerable<int>, TwitterResponse> action);		

		IAsyncResult ListUserIdsWhoRetweeted(long id, int count, Action<IEnumerable<int>, TwitterResponse> action);		

		IAsyncResult GetUserProfile(Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult GetUserProfileFor(string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult GetUserProfileFor(int id, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult SearchForUser(string q, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult SearchForUser(string q, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult SearchForUser(string q, int page, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListUserProfilesFor(string userId, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult GetProfileImageFor(string screenName, Action<byte[], TwitterResponse> action);		

		IAsyncResult GetProfileImageFor(string screenName, TwitterProfileImageSize size, Action<byte[], TwitterResponse> action);		

		IAsyncResult ListSuggestedUserCategories(Action<IEnumerable<TwitterUserSuggestions>, TwitterResponse> action);		

		IAsyncResult ListSuggestedUsers(string categorySlug, Action<TwitterUserSuggestions, TwitterResponse> action);		

		#endregion
#endif

#if !WINDOWS_PHONE
		#region Asynchronous Methods (with Begin/End pattern)
		IAsyncResult BeginVerifyCredentials();

		TwitterUser EndVerifyCredentials(IAsyncResult result);		

		TwitterUser EndVerifyCredentials(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetRateLimitStatus();

		TwitterRateLimitStatus EndGetRateLimitStatus(IAsyncResult result);		

		TwitterRateLimitStatus EndGetRateLimitStatus(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginEndSession();

		TwitterError EndEndSession(IAsyncResult result);		

		TwitterError EndEndSession(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUpdateDeliveryDevice();

		TwitterUser EndUpdateDeliveryDevice(IAsyncResult result);		

		TwitterUser EndUpdateDeliveryDevice(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUpdateProfileColors();

		TwitterUser EndUpdateProfileColors(IAsyncResult result);		

		TwitterUser EndUpdateProfileColors(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUpdateProfileImage();

		TwitterUser EndUpdateProfileImage(IAsyncResult result);		

		TwitterUser EndUpdateProfileImage(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUpdateProfileBackgroundImage();

		TwitterUser EndUpdateProfileBackgroundImage(IAsyncResult result);		

		TwitterUser EndUpdateProfileBackgroundImage(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUpdateProfile();

		TwitterUser EndUpdateProfile(IAsyncResult result);		

		TwitterUser EndUpdateProfile(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetConfiguration();

		TwitterConfiguration EndGetConfiguration(IAsyncResult result);		

		TwitterConfiguration EndGetConfiguration(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginBlockUser();

		TwitterUser EndBlockUser(IAsyncResult result);		

		TwitterUser EndBlockUser(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUnblockUser();

		TwitterUser EndUnblockUser(IAsyncResult result);		

		TwitterUser EndUnblockUser(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginVerifyBlocking();

		TwitterUser EndVerifyBlocking(IAsyncResult result);		

		TwitterUser EndVerifyBlocking(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListBlockedUsers();

		IEnumerable<TwitterUser> EndListBlockedUsers(IAsyncResult result);		

		IEnumerable<TwitterUser> EndListBlockedUsers(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListBlockedUserIds();

		IEnumerable<int> EndListBlockedUserIds(IAsyncResult result);		

		IEnumerable<int> EndListBlockedUserIds(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListDirectMessagesReceived();

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceived(IAsyncResult result);		

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceived(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListDirectMessagesReceivedSince();

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedSince(IAsyncResult result);		

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListDirectMessagesReceivedBefore();

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedBefore(IAsyncResult result);		

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListDirectMessagesSent();

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesSent(IAsyncResult result);		

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesSent(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListDirectMessagesSentSince();

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentSince(IAsyncResult result);		

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListDirectMessagesSentBefore();

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentBefore(IAsyncResult result);		

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginDeleteDirectMessage();

		TwitterDirectMessage EndDeleteDirectMessage(IAsyncResult result);		

		TwitterDirectMessage EndDeleteDirectMessage(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginSendDirectMessage();

		TwitterDirectMessage EndSendDirectMessage(IAsyncResult result);		

		TwitterDirectMessage EndSendDirectMessage(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListFavoriteTweets();

		IEnumerable<TwitterStatus> EndListFavoriteTweets(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListFavoriteTweets(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListFavoriteTweetsFor();

		IEnumerable<TwitterStatus> EndListFavoriteTweetsFor(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListFavoriteTweetsFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginFavoriteTweet();

		TwitterStatus EndFavoriteTweet(IAsyncResult result);		

		TwitterStatus EndFavoriteTweet(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUnfavoriteTweet();

		TwitterStatus EndUnfavoriteTweet(IAsyncResult result);		

		TwitterStatus EndUnfavoriteTweet(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListFriendIdsOf();

		TwitterCursorList<int> EndListFriendIdsOf(IAsyncResult result);		

		TwitterCursorList<int> EndListFriendIdsOf(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListFollowerIdsOf();

		TwitterCursorList<int> EndListFollowerIdsOf(IAsyncResult result);		

		TwitterCursorList<int> EndListFollowerIdsOf(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginFollowUser();

		TwitterUser EndFollowUser(IAsyncResult result);		

		TwitterUser EndFollowUser(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUnfollowUser();

		TwitterUser EndUnfollowUser(IAsyncResult result);		

		TwitterUser EndUnfollowUser(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetIncomingFriendRequests();

		TwitterCursorList<int> EndGetIncomingFriendRequests(IAsyncResult result);		

		TwitterCursorList<int> EndGetIncomingFriendRequests(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetOutgoingFriendRequests();

		TwitterCursorList<int> EndGetOutgoingFriendRequests(IAsyncResult result);		

		TwitterCursorList<int> EndGetOutgoingFriendRequests(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetFriendshipInfo();

		TwitterFriendship EndGetFriendshipInfo(IAsyncResult result);		

		TwitterFriendship EndGetFriendshipInfo(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginCreateList();

		TwitterList EndCreateList(IAsyncResult result);		

		TwitterList EndCreateList(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUpdateList();

		TwitterList EndUpdateList(IAsyncResult result);		

		TwitterList EndUpdateList(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListLists();

		TwitterCursorList<TwitterList> EndListLists(IAsyncResult result);		

		TwitterCursorList<TwitterList> EndListLists(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListListsFor();

		TwitterCursorList<TwitterList> EndListListsFor(IAsyncResult result);		

		TwitterCursorList<TwitterList> EndListListsFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetList();

		TwitterList EndGetList(IAsyncResult result);		

		TwitterList EndGetList(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginDeleteList();

		TwitterList EndDeleteList(IAsyncResult result);		

		TwitterList EndDeleteList(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnList();

		IEnumerable<TwitterStatus> EndListTweetsOnList(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnList(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnListSince();

		IEnumerable<TwitterStatus> EndListTweetsOnListSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnListSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnListBefore();

		IEnumerable<TwitterStatus> EndListTweetsOnListBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnListBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListListMemberships();

		TwitterCursorList<TwitterList> EndListListMemberships(IAsyncResult result);		

		TwitterCursorList<TwitterList> EndListListMemberships(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListListMembershipsFor();

		TwitterCursorList<TwitterList> EndListListMembershipsFor(IAsyncResult result);		

		TwitterCursorList<TwitterList> EndListListMembershipsFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListListMembers();

		TwitterCursorList<TwitterUser> EndListListMembers(IAsyncResult result);		

		TwitterCursorList<TwitterUser> EndListListMembers(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginAddListMember();

		TwitterUser EndAddListMember(IAsyncResult result);		

		TwitterUser EndAddListMember(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginRemoveListMember();

		TwitterUser EndRemoveListMember(IAsyncResult result);		

		TwitterUser EndRemoveListMember(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginAddListMembers();

		TwitterCursorList<TwitterList> EndAddListMembers(IAsyncResult result);		

		TwitterCursorList<TwitterList> EndAddListMembers(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginAddListMembersByScreenName();

		TwitterCursorList<TwitterList> EndAddListMembersByScreenName(IAsyncResult result);		

		TwitterCursorList<TwitterList> EndAddListMembersByScreenName(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginVerifyListMembership();

		TwitterUser EndVerifyListMembership(IAsyncResult result);		

		TwitterUser EndVerifyListMembership(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListListSubscriptions();

		IEnumerable<TwitterList> EndListListSubscriptions(IAsyncResult result);		

		IEnumerable<TwitterList> EndListListSubscriptions(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListListSubscriptionsFor();

		IEnumerable<TwitterList> EndListListSubscriptionsFor(IAsyncResult result);		

		IEnumerable<TwitterList> EndListListSubscriptionsFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListListSubscribers();

		TwitterCursorList<TwitterUser> EndListListSubscribers(IAsyncResult result);		

		TwitterCursorList<TwitterUser> EndListListSubscribers(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginFollowList();

		TwitterUser EndFollowList(IAsyncResult result);		

		TwitterUser EndFollowList(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUnfollowList();

		TwitterUser EndUnfollowList(IAsyncResult result);		

		TwitterUser EndUnfollowList(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginVerifyListSubscription();

		TwitterUser EndVerifyListSubscription(IAsyncResult result);		

		TwitterUser EndVerifyListSubscription(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginFollowUserNotifications();

		TwitterUser EndFollowUserNotifications(IAsyncResult result);		

		TwitterUser EndFollowUserNotifications(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUnfollowUserNotifications();

		TwitterUser EndUnfollowUserNotifications(IAsyncResult result);		

		TwitterUser EndUnfollowUserNotifications(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListSavedSearches();

		IEnumerable<TwitterSavedSearch> EndListSavedSearches(IAsyncResult result);		

		IEnumerable<TwitterSavedSearch> EndListSavedSearches(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetSavedSearch();

		TwitterSavedSearch EndGetSavedSearch(IAsyncResult result);		

		TwitterSavedSearch EndGetSavedSearch(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginCreateSavedSearch();

		TwitterSavedSearch EndCreateSavedSearch(IAsyncResult result);		

		TwitterSavedSearch EndCreateSavedSearch(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginDeleteSavedSearch();

		TwitterSavedSearch EndDeleteSavedSearch(IAsyncResult result);		

		TwitterSavedSearch EndDeleteSavedSearch(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginSearch();

		TwitterSearchResult EndSearch(IAsyncResult result);		

		TwitterSearchResult EndSearch(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginSearchSince();

		TwitterSearchResult EndSearchSince(IAsyncResult result);		

		TwitterSearchResult EndSearchSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginSearchBefore();

		TwitterSearchResult EndSearchBefore(IAsyncResult result);		

		TwitterSearchResult EndSearchBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginReportSpam();

		TwitterUser EndReportSpam(IAsyncResult result);		

		TwitterUser EndReportSpam(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnHomeTimeline();

		IEnumerable<TwitterStatus> EndListTweetsOnHomeTimeline(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnHomeTimeline(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnHomeTimelineSince();

		IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnHomeTimelineBefore();

		IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnUserTimeline();

		IEnumerable<TwitterStatus> EndListTweetsOnUserTimeline(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnUserTimeline(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnUserTimelineSince();

		IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnUserTimelineBefore();

		IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnSpecifiedUserTimeline();

		IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimeline(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimeline(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince();

		IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore();

		IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsMentioningMe();

		IEnumerable<TwitterStatus> EndListTweetsMentioningMe(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsMentioningMe(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsMentioningMeSince();

		IEnumerable<TwitterStatus> EndListTweetsMentioningMeSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsMentioningMeSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsMentioningMeBefore();

		IEnumerable<TwitterStatus> EndListTweetsMentioningMeBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsMentioningMeBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsByMe();

		IEnumerable<TwitterStatus> EndListRetweetsByMe(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsByMe(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsByMeSince();

		IEnumerable<TwitterStatus> EndListRetweetsByMeSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsByMeSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsByMeBefore();

		IEnumerable<TwitterStatus> EndListRetweetsByMeBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsByMeBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsToMe();

		IEnumerable<TwitterStatus> EndListRetweetsToMe(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsToMe(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsToMeSince();

		IEnumerable<TwitterStatus> EndListRetweetsToMeSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsToMeSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsToMeBefore();

		IEnumerable<TwitterStatus> EndListRetweetsToMeBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsToMeBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsOfMyTweets();

		IEnumerable<TwitterStatus> EndListRetweetsOfMyTweets(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsOfMyTweets(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsOfMyTweetsSince();

		IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsOfMyTweetsBefore();

		IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListCurrentTrends();

		TwitterCurrentTrends EndListCurrentTrends(IAsyncResult result);		

		TwitterCurrentTrends EndListCurrentTrends(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListDailyTrends();

		TwitterTrends EndListDailyTrends(IAsyncResult result);		

		TwitterTrends EndListDailyTrends(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListWeeklyTrends();

		TwitterTrends EndListWeeklyTrends(IAsyncResult result);		

		TwitterTrends EndListWeeklyTrends(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListAvailableTrendsLocations();

		IEnumerable<WhereOnEarthLocation> EndListAvailableTrendsLocations(IAsyncResult result);		

		IEnumerable<WhereOnEarthLocation> EndListAvailableTrendsLocations(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListLocalTrendsFor();

		TwitterLocalTrends EndListLocalTrendsFor(IAsyncResult result);		

		TwitterLocalTrends EndListLocalTrendsFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetTweet();

		TwitterStatus EndGetTweet(IAsyncResult result);		

		TwitterStatus EndGetTweet(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginSendTweet();

		TwitterStatus EndSendTweet(IAsyncResult result);		

		TwitterStatus EndSendTweet(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginDeleteTweet();

		TwitterStatus EndDeleteTweet(IAsyncResult result);		

		TwitterStatus EndDeleteTweet(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginRetweet();

		TwitterStatus EndRetweet(IAsyncResult result);		

		TwitterStatus EndRetweet(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginRetweets();

		IEnumerable<TwitterStatus> EndRetweets(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndRetweets(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListUsersWhoRetweeted();

		IEnumerable<TwitterUser> EndListUsersWhoRetweeted(IAsyncResult result);		

		IEnumerable<TwitterUser> EndListUsersWhoRetweeted(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListUserIdsWhoRetweeted();

		IEnumerable<int> EndListUserIdsWhoRetweeted(IAsyncResult result);		

		IEnumerable<int> EndListUserIdsWhoRetweeted(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetUserProfile();

		TwitterUser EndGetUserProfile(IAsyncResult result);		

		TwitterUser EndGetUserProfile(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetUserProfileFor();

		TwitterUser EndGetUserProfileFor(IAsyncResult result);		

		TwitterUser EndGetUserProfileFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginSearchForUser();

		IEnumerable<TwitterUser> EndSearchForUser(IAsyncResult result);		

		IEnumerable<TwitterUser> EndSearchForUser(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListUserProfilesFor();

		IEnumerable<TwitterUser> EndListUserProfilesFor(IAsyncResult result);		

		IEnumerable<TwitterUser> EndListUserProfilesFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetProfileImageFor();

		byte[] EndGetProfileImageFor(IAsyncResult result);		

		byte[] EndGetProfileImageFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListSuggestedUserCategories();

		IEnumerable<TwitterUserSuggestions> EndListSuggestedUserCategories(IAsyncResult result);		

		IEnumerable<TwitterUserSuggestions> EndListSuggestedUserCategories(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListSuggestedUsers();

		TwitterUserSuggestions EndListSuggestedUsers(IAsyncResult result);		

		TwitterUserSuggestions EndListSuggestedUsers(IAsyncResult result, TimeSpan timeout);

		#endregion
#endif
	
#if WINDOWS_PHONE
		#region Asynchronous Methods (without IAsyncResult)
		void VerifyCredentials(Action<TwitterUser, TwitterResponse> action);

		void GetRateLimitStatus(Action<TwitterRateLimitStatus, TwitterResponse> action);

		void EndSession(Action<TwitterError, TwitterResponse> action);

		void UpdateDeliveryDevice(TwitterDeliveryDevice device, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, string sidebarBorderColor, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfileColors(string backgroundColor, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfileColors(string backgroundColor, string textColor, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfileColors(string backgroundColor, string textColor, string linkColor, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfileImage(string path, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfileBackgroundImage(string path, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfile(string name, string description, string email, string url, string location, Action<TwitterUser, TwitterResponse> action);

		void GetConfiguration(Action<TwitterConfiguration, TwitterResponse> action);

		void BlockUser(int userId, Action<TwitterUser, TwitterResponse> action);

		void BlockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action);

		void UnblockUser(int userId, Action<TwitterUser, TwitterResponse> action);

		void UnblockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action);

		void VerifyBlocking(int userId, Action<TwitterUser, TwitterResponse> action);

		void VerifyBlocking(string userScreenName, Action<TwitterUser, TwitterResponse> action);

		void ListBlockedUsers(Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void ListBlockedUsers(int page, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void ListBlockedUserIds(Action<IEnumerable<int>, TwitterResponse> action);

		void ListDirectMessagesReceived(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceived(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceived(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceivedSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceivedSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceivedSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceivedBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceivedBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceivedBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSent(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSent(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSent(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSentSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSentSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSentSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSentBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSentBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSentBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void DeleteDirectMessage(long id, Action<TwitterDirectMessage, TwitterResponse> action);

		void DeleteDirectMessage(int id, Action<TwitterDirectMessage, TwitterResponse> action);

		void SendDirectMessage(int userId, string text, Action<TwitterDirectMessage, TwitterResponse> action);

		void SendDirectMessage(string screenName, string text, Action<TwitterDirectMessage, TwitterResponse> action);

		void ListFavoriteTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweets(int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweetsFor(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweetsFor(int userId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweetsFor(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweetsFor(string userScreenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweetsFor(string userScreenName, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweetsFor(string userScreenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void FavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action);

		void UnfavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action);

		void ListFriendIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);

		void ListFriendIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);

		void ListFollowerIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);

		void ListFollowerIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);

		void FollowUser(int userId, Action<TwitterUser, TwitterResponse> action);

		void FollowUser(string screenName, Action<TwitterUser, TwitterResponse> action);

		void UnfollowUser(string screenName, Action<TwitterUser, TwitterResponse> action);

		void UnfollowUser(int userId, Action<TwitterUser, TwitterResponse> action);

		void GetIncomingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action);

		void GetIncomingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);

		void GetOutgoingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action);

		void GetOutgoingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);

		void GetFriendshipInfo(string sourceScreenName, string targetScreenName, Action<TwitterFriendship, TwitterResponse> action);

		void GetFriendshipInfo(int sourceId, int targetId, Action<TwitterFriendship, TwitterResponse> action);

		void CreateList(string name, Action<TwitterList, TwitterResponse> action);

		void CreateList(string name, string description, Action<TwitterList, TwitterResponse> action);

		void CreateList(string name, string description, string mode, Action<TwitterList, TwitterResponse> action);

		void UpdateList(long listId, string name, Action<TwitterList, TwitterResponse> action);

		void UpdateList(long listId, string name, string description, Action<TwitterList, TwitterResponse> action);

		void UpdateList(long listId, string name, string description, string mode, Action<TwitterList, TwitterResponse> action);

		void UpdateList(string slug, int ownerId, string name, Action<TwitterList, TwitterResponse> action);

		void UpdateList(string slug, int ownerId, string name, string description, Action<TwitterList, TwitterResponse> action);

		void UpdateList(string slug, int ownerId, string name, string description, string mode, Action<TwitterList, TwitterResponse> action);

		void UpdateList(string slug, string ownerScreenName, string name, Action<TwitterList, TwitterResponse> action);

		void UpdateList(string slug, string ownerScreenName, string name, string description, Action<TwitterList, TwitterResponse> action);

		void UpdateList(string slug, string ownerScreenName, string name, string description, string mode, Action<TwitterList, TwitterResponse> action);

		void ListLists(Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void ListLists(long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void ListListsFor(int userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void ListListsFor(int userId, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void ListListsFor(string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void ListListsFor(string screenName, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void GetList(int userId, Action<TwitterList, TwitterResponse> action);

		void GetList(string slug, int ownerId, Action<TwitterList, TwitterResponse> action);

		void GetList(string slug, string ownerScreenName, Action<TwitterList, TwitterResponse> action);

		void DeleteList(long listId, Action<TwitterList, TwitterResponse> action);

		void DeleteList(string slug, int ownerId, Action<TwitterList, TwitterResponse> action);

		void DeleteList(string slug, string ownerScreenName, Action<TwitterList, TwitterResponse> action);

		void ListTweetsOnList(long listId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(long listId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(long listId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(long listId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(long listId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(long listId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(string slug, int ownerId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(string slug, int ownerId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(string slug, int ownerId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(string slug, int ownerId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(string slug, int ownerId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(string slug, int ownerId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(string slug, string ownerScreenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(string slug, string ownerScreenName, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(string slug, string ownerScreenName, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(string slug, string ownerScreenName, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(string slug, string ownerScreenName, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(string slug, string ownerScreenName, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(long listId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(long listId, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(long listId, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(long listId, long sinceId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(long listId, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(long listId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(string slug, int ownerId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(string slug, int ownerId, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(string slug, int ownerId, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(string slug, int ownerId, long sinceId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(string slug, int ownerId, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(string slug, int ownerId, long sinceId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(long listId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(long listId, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(long listId, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(long listId, long maxId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(long listId, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(long listId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(string slug, int ownerId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(string slug, int ownerId, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(string slug, int ownerId, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(string slug, int ownerId, long maxId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(string slug, int ownerId, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(string slug, int ownerId, long maxId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListListMemberships(Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void ListListMembershipsFor(int userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void ListListMembershipsFor(int userId, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void ListListMembershipsFor(int userId, bool filterToOwnedLists, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void ListListMembershipsFor(int userId, bool filterToOwnedLists, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void ListListMembershipsFor(string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void ListListMembershipsFor(string screenName, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void ListListMembershipsFor(string screenName, bool filterToOwnedLists, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void ListListMembershipsFor(string screenName, bool filterToOwnedLists, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void ListListMembers(long listId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListListMembers(long listId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListListMembers(long listId, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListListMembers(long listId, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListListMembers(string slug, int ownerId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListListMembers(string slug, int ownerId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListListMembers(string slug, string ownerScreenName, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListListMembers(string slug, string ownerScreenName, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void AddListMember(long listId, int userId, Action<TwitterUser, TwitterResponse> action);

		void AddListMember(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action);

		void AddListMember(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action);

		void AddListMember(long listId, string screenName, Action<TwitterUser, TwitterResponse> action);

		void AddListMember(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action);

		void AddListMember(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action);

		void RemoveListMember(long listId, int userId, Action<TwitterUser, TwitterResponse> action);

		void RemoveListMember(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action);

		void RemoveListMember(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action);

		void RemoveListMember(long listId, string screenName, Action<TwitterUser, TwitterResponse> action);

		void RemoveListMember(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action);

		void RemoveListMember(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action);

		void AddListMembers(long listId, string userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void AddListMembersByScreenName(long listId, string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void AddListMembers(string slug, int ownerId, string userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void AddListMembersByScreenName(string slug, int ownerId, string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void AddListMembers(string slug, string ownerScreenName, string userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void AddListMembersByScreenName(string slug, string ownerScreenName, string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void VerifyListMembership(long listId, int userId, Action<TwitterUser, TwitterResponse> action);

		void VerifyListMembership(long listId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action);

		void VerifyListMembership(long listId, string screenName, Action<TwitterUser, TwitterResponse> action);

		void VerifyListMembership(long listId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action);

		void VerifyListMembership(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action);

		void VerifyListMembership(string slug, int ownerId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action);

		void VerifyListMembership(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action);

		void VerifyListMembership(string slug, int ownerId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action);

		void VerifyListMembership(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action);

		void VerifyListMembership(string slug, string ownerScreenName, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action);

		void VerifyListMembership(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action);

		void VerifyListMembership(string slug, string ownerScreenName, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action);

		void ListListSubscriptions(Action<IEnumerable<TwitterList>, TwitterResponse> action);

		void ListListSubscriptionsFor(int userId, Action<IEnumerable<TwitterList>, TwitterResponse> action);

		void ListListSubscriptionsFor(string screenName, Action<IEnumerable<TwitterList>, TwitterResponse> action);

		void ListListSubscribers(long listId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListListSubscribers(long listId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListListSubscribers(long listId, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListListSubscribers(long listId, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListListSubscribers(string slug, int ownerId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListListSubscribers(string slug, int ownerId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListListSubscribers(string slug, string ownerScreenName, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListListSubscribers(string slug, string ownerScreenName, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void FollowList(long listId, Action<TwitterUser, TwitterResponse> action);

		void FollowList(string slug, int ownerId, Action<TwitterUser, TwitterResponse> action);

		void FollowList(string slug, string ownerScreenName, Action<TwitterUser, TwitterResponse> action);

		void UnfollowList(long listId, Action<TwitterUser, TwitterResponse> action);

		void UnfollowList(string slug, int ownerId, Action<TwitterUser, TwitterResponse> action);

		void UnfollowList(string slug, string ownerScreenName, Action<TwitterUser, TwitterResponse> action);

		void VerifyListSubscription(long listId, int userId, Action<TwitterUser, TwitterResponse> action);

		void VerifyListSubscription(long listId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action);

		void VerifyListSubscription(long listId, string screenName, Action<TwitterUser, TwitterResponse> action);

		void VerifyListSubscription(long listId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action);

		void VerifyListSubscription(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action);

		void VerifyListSubscription(string slug, int ownerId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action);

		void VerifyListSubscription(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action);

		void VerifyListSubscription(string slug, int ownerId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action);

		void VerifyListSubscription(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action);

		void VerifyListSubscription(string slug, string ownerScreenName, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action);

		void VerifyListSubscription(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action);

		void VerifyListSubscription(string slug, string ownerScreenName, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action);

		void FollowUserNotifications(string screenName, Action<TwitterUser, TwitterResponse> action);

		void FollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action);

		void UnfollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action);

		void UnfollowUserNotifications(string userScreenName, Action<TwitterUser, TwitterResponse> action);

		void ListSavedSearches(Action<IEnumerable<TwitterSavedSearch>, TwitterResponse> action);

		void GetSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action);

		void CreateSavedSearch(string query, Action<TwitterSavedSearch, TwitterResponse> action);

		void DeleteSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action);

		void Search(string q, Action<TwitterSearchResult, TwitterResponse> action);

		void Search(string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void Search(string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action);

		void Search(string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void Search(string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action);

		void Search(string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchSince(long since_id, string q, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchSince(long since_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchSince(long since_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchSince(long since_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchSince(long since_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchSince(long since_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchBefore(long max_id, string q, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchBefore(long max_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchBefore(long max_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchBefore(long max_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchBefore(long max_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchBefore(long max_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void ReportSpam(int userId, Action<TwitterUser, TwitterResponse> action);

		void ReportSpam(string userScreenName, Action<TwitterUser, TwitterResponse> action);

		void ListTweetsOnHomeTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimeline(bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimeline(int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimeline(int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineSince(long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineSince(long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineSince(long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineBefore(long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineBefore(long maxId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineBefore(long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimeline(bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimeline(int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimeline(int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineSince(long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineSince(long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineSince(long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineBefore(long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineBefore(long maxId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineBefore(long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(int userId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(string screenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(string screenName, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(int userId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(int userId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(string screenName, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(string screenName, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMe(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweets(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweets(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweetsSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweetsSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweetsSince(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweetsBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweetsBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListCurrentTrends(int woeid, Action<TwitterCurrentTrends, TwitterResponse> action);

		void ListCurrentTrends(string exclude, int woeid, Action<TwitterCurrentTrends, TwitterResponse> action);

		void ListDailyTrends(Action<TwitterTrends, TwitterResponse> action);

		void ListDailyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action);

		void ListDailyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action);

		void ListDailyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action);

		void ListWeeklyTrends(Action<TwitterTrends, TwitterResponse> action);

		void ListWeeklyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action);

		void ListWeeklyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action);

		void ListWeeklyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action);

		void ListAvailableTrendsLocations(Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action);

		void ListAvailableTrendsLocations(string lat, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action);

		void ListAvailableTrendsLocations(string lat, string @long, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action);

		void ListLocalTrendsFor(long woeId, Action<TwitterLocalTrends, TwitterResponse> action);

		void GetTweet(long id, Action<TwitterStatus, TwitterResponse> action);

		void SendTweet(string status, Action<TwitterStatus, TwitterResponse> action);

		void SendTweet(string status, string lat, string @long, Action<TwitterStatus, TwitterResponse> action);

		void SendTweet(string status, long inReplyToStatusId, Action<TwitterStatus, TwitterResponse> action);

		void SendTweet(string status, long inReplyToStatusId, string lat, string @long, Action<TwitterStatus, TwitterResponse> action);

		void DeleteTweet(long id, Action<TwitterStatus, TwitterResponse> action);

		void Retweet(long id, Action<TwitterStatus, TwitterResponse> action);

		void Retweets(long id, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void Retweets(long id, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListUsersWhoRetweeted(long id, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void ListUsersWhoRetweeted(long id, int count, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void ListUserIdsWhoRetweeted(long id, Action<IEnumerable<int>, TwitterResponse> action);

		void ListUserIdsWhoRetweeted(long id, int count, Action<IEnumerable<int>, TwitterResponse> action);

		void GetUserProfile(Action<TwitterUser, TwitterResponse> action);

		void GetUserProfileFor(string screenName, Action<TwitterUser, TwitterResponse> action);

		void GetUserProfileFor(int id, Action<TwitterUser, TwitterResponse> action);

		void SearchForUser(string q, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void SearchForUser(string q, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void SearchForUser(string q, int page, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void ListUserProfilesFor(string userId, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void GetProfileImageFor(string screenName, Action<byte[], TwitterResponse> action);

		void GetProfileImageFor(string screenName, TwitterProfileImageSize size, Action<byte[], TwitterResponse> action);

		void ListSuggestedUserCategories(Action<IEnumerable<TwitterUserSuggestions>, TwitterResponse> action);

		void ListSuggestedUsers(string categorySlug, Action<TwitterUserSuggestions, TwitterResponse> action);

		#endregion
#endif		
	}
#endregion
}

namespace TweetSharp
{
#region Implementation
	public partial class TwitterService
	{	
#if !SILVERLIGHT
		#region Sequential Methods
		public virtual TwitterUser VerifyCredentials()
		{
			return WithHammock<TwitterUser>("account/verify_credentials", FormatAsString);
		}

		public virtual TwitterRateLimitStatus GetRateLimitStatus()
		{
			return WithHammock<TwitterRateLimitStatus>("account/rate_limit_status", FormatAsString);
		}

		public virtual TwitterError EndSession()
		{
			return WithHammock<TwitterError>(WebMethod.Post, "account/end_session", FormatAsString);
		}

		public virtual TwitterUser UpdateDeliveryDevice(TwitterDeliveryDevice device)
		{
			return WithHammock<TwitterUser>("account/update_delivery_device", FormatAsString, "?device=", device);
		}

		public virtual TwitterUser UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, string sidebarBorderColor)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor, "&sidebar_border_color=", sidebarBorderColor);
		}

		public virtual TwitterUser UpdateProfileColors(string backgroundColor)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor);
		}

		public virtual TwitterUser UpdateProfileColors(string backgroundColor, string textColor)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor);
		}

		public virtual TwitterUser UpdateProfileColors(string backgroundColor, string textColor, string linkColor)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor);
		}

		public virtual TwitterUser UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor);
		}

		public virtual TwitterUser UpdateProfileImage(string path)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_image", FormatAsString, "?path=", path);
		}

		public virtual TwitterUser UpdateProfileBackgroundImage(string path)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_background_image", FormatAsString, "?path=", path);
		}

		public virtual TwitterUser UpdateProfile(string name, string description, string email, string url, string location)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile", FormatAsString, "?name=", name, "&description=", description, "&email=", email, "&url=", url, "&location=", location);
		}

		public virtual TwitterConfiguration GetConfiguration()
		{
			return WithHammock<TwitterConfiguration>("help/configuration", FormatAsString);
		}

		public virtual TwitterUser BlockUser(int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "blocks/create", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterUser BlockUser(string userScreenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "blocks/create", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual TwitterUser UnblockUser(int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Delete, "blocks/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterUser UnblockUser(string userScreenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Delete, "blocks/destroy", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual TwitterUser VerifyBlocking(int userId)
		{
			return WithHammock<TwitterUser>("blocks/exists", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterUser VerifyBlocking(string userScreenName)
		{
			return WithHammock<TwitterUser>("blocks/exists", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IEnumerable<TwitterUser> ListBlockedUsers()
		{
			return WithHammock<IEnumerable<TwitterUser>>("blocks/blocking", FormatAsString);
		}

		public virtual IEnumerable<TwitterUser> ListBlockedUsers(int page)
		{
			return WithHammock<IEnumerable<TwitterUser>>("blocks/blocking", FormatAsString, "?page=", page);
		}

		public virtual IEnumerable<int> ListBlockedUserIds()
		{
			return WithHammock<IEnumerable<int>>("blocks/blocking/ids", FormatAsString);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceived()
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceived(int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceived(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedSince(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedBefore(long maxId)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSent()
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSent(int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSent(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSentSince(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSentSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSentSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSentBefore(long maxId)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSentBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSentBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual TwitterDirectMessage DeleteDirectMessage(long id)
		{
			return WithHammock<TwitterDirectMessage>(WebMethod.Delete, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual TwitterDirectMessage DeleteDirectMessage(int id)
		{
			return WithHammock<TwitterDirectMessage>(WebMethod.Delete, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual TwitterDirectMessage SendDirectMessage(int userId, string text)
		{
			return WithHammock<TwitterDirectMessage>(WebMethod.Post, "direct_messages/new", FormatAsString, "?user_id=", userId, "&text=", text);
		}

		public virtual TwitterDirectMessage SendDirectMessage(string screenName, string text)
		{
			return WithHammock<TwitterDirectMessage>(WebMethod.Post, "direct_messages/new", FormatAsString, "?screen_name=", screenName, "&text=", text);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweets()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweets(int page)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites", FormatAsString, "?page=", page);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweets(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweetsFor(int userId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites/{user_screen_name}", FormatAsString, "?user_id=", userId);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweetsFor(int userId, int page)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweetsFor(int userId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweetsFor(string userScreenName)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweetsFor(string userScreenName, int page)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweetsFor(string userScreenName, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page, "&count=", count);
		}

		public virtual TwitterStatus FavoriteTweet(long id)
		{
			return WithHammock<TwitterStatus>(WebMethod.Post, "favorites/create/{id}", FormatAsString, "?id=", id);
		}

		public virtual TwitterStatus UnfavoriteTweet(long id)
		{
			return WithHammock<TwitterStatus>(WebMethod.Delete, "favorites/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual TwitterCursorList<int> ListFriendIdsOf(string screenName, long cursor)
		{
			return WithHammock<TwitterCursorList<int>>("friends/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<int> ListFriendIdsOf(int userId, long cursor)
		{
			return WithHammock<TwitterCursorList<int>>("friends/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<int> ListFollowerIdsOf(int userId, long cursor)
		{
			return WithHammock<TwitterCursorList<int>>("followers/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<int> ListFollowerIdsOf(string screenName, long cursor)
		{
			return WithHammock<TwitterCursorList<int>>("followers/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual TwitterUser FollowUser(int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "friendships/create", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterUser FollowUser(string screenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "friendships/create", FormatAsString, "?screen_name=", screenName);
		}

		public virtual TwitterUser UnfollowUser(string screenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Delete, "friendships/destroy", FormatAsString, "?screen_name=", screenName);
		}

		public virtual TwitterUser UnfollowUser(int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Delete, "friendships/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterCursorList<int> GetIncomingFriendRequests()
		{
			return WithHammock<TwitterCursorList<int>>("friendships/incoming", FormatAsString);
		}

		public virtual TwitterCursorList<int> GetIncomingFriendRequests(long cursor)
		{
			return WithHammock<TwitterCursorList<int>>("friendships/incoming", FormatAsString, "?cursor=", cursor);
		}

		public virtual TwitterCursorList<int> GetOutgoingFriendRequests()
		{
			return WithHammock<TwitterCursorList<int>>("friendships/outgoing", FormatAsString);
		}

		public virtual TwitterCursorList<int> GetOutgoingFriendRequests(long cursor)
		{
			return WithHammock<TwitterCursorList<int>>("friendships/outgoing", FormatAsString, "?cursor=", cursor);
		}

		public virtual TwitterFriendship GetFriendshipInfo(string sourceScreenName, string targetScreenName)
		{
			return WithHammock<TwitterFriendship>("friendships/show", FormatAsString, "?source_screen_name=", sourceScreenName, "&target_screen_name=", targetScreenName);
		}

		public virtual TwitterFriendship GetFriendshipInfo(int sourceId, int targetId)
		{
			return WithHammock<TwitterFriendship>("friendships/show", FormatAsString, "?source_id=", sourceId, "&target_id=", targetId);
		}

		public virtual TwitterList CreateList(string name)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/create", FormatAsString, "?name=", name);
		}

		public virtual TwitterList CreateList(string name, string description)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/create", FormatAsString, "?name=", name, "&description=", description);
		}

		public virtual TwitterList CreateList(string name, string description, string mode)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/create", FormatAsString, "?name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual TwitterList UpdateList(long listId, string name)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?list_id=", listId, "&name=", name);
		}

		public virtual TwitterList UpdateList(long listId, string name, string description)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?list_id=", listId, "&name=", name, "&description=", description);
		}

		public virtual TwitterList UpdateList(long listId, string name, string description, string mode)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?list_id=", listId, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual TwitterList UpdateList(string slug, int ownerId, string name)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&name=", name);
		}

		public virtual TwitterList UpdateList(string slug, int ownerId, string name, string description)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&name=", name, "&description=", description);
		}

		public virtual TwitterList UpdateList(string slug, int ownerId, string name, string description, string mode)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual TwitterList UpdateList(string slug, string ownerScreenName, string name)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&name=", name);
		}

		public virtual TwitterList UpdateList(string slug, string ownerScreenName, string name, string description)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&name=", name, "&description=", description);
		}

		public virtual TwitterList UpdateList(string slug, string ownerScreenName, string name, string description, string mode)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual TwitterCursorList<TwitterList> ListLists()
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists", FormatAsString);
		}

		public virtual TwitterCursorList<TwitterList> ListLists(long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists", FormatAsString, "?cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterList> ListListsFor(int userId)
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterCursorList<TwitterList> ListListsFor(int userId, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterList> ListListsFor(string screenName)
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists", FormatAsString, "?screen_name=", screenName);
		}

		public virtual TwitterCursorList<TwitterList> ListListsFor(string screenName, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual TwitterList GetList(int userId)
		{
			return WithHammock<TwitterList>("lists/show", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterList GetList(string slug, int ownerId)
		{
			return WithHammock<TwitterList>("lists/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual TwitterList GetList(string slug, string ownerScreenName)
		{
			return WithHammock<TwitterList>("lists/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual TwitterList DeleteList(long listId)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/destroy", FormatAsString, "?list_id=", listId);
		}

		public virtual TwitterList DeleteList(string slug, int ownerId)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/destroy", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual TwitterList DeleteList(string slug, string ownerScreenName)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/destroy", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(long listId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(long listId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(long listId, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(long listId, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(long listId, int page, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(long listId, int page, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(string slug, int ownerId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(string slug, int ownerId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(string slug, int ownerId, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(string slug, int ownerId, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(string slug, int ownerId, int page, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(string slug, int ownerId, int page, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(string slug, string ownerScreenName)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(string slug, string ownerScreenName, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(string slug, string ownerScreenName, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(string slug, string ownerScreenName, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(string slug, string ownerScreenName, int page, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&page=", page, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(string slug, string ownerScreenName, int page, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(long listId, long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(long listId, long sinceId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(long listId, long sinceId, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(long listId, long sinceId, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(long listId, long sinceId, int page, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(long listId, int page, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, int ownerId, long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, int ownerId, long sinceId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, int ownerId, long sinceId, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, int ownerId, long sinceId, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, int ownerId, long sinceId, int page, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, int ownerId, long sinceId, int page, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int page, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int page, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(long listId, long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(long listId, long maxId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(long listId, long maxId, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(long listId, long maxId, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(long listId, long maxId, int page, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(long listId, int page, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, int ownerId, long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, int ownerId, long maxId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, int ownerId, long maxId, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, int ownerId, long maxId, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, int ownerId, long maxId, int page, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, int ownerId, long maxId, int page, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int page, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int page, int perPage, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual TwitterCursorList<TwitterList> ListListMemberships()
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists/memberships", FormatAsString);
		}

		public virtual TwitterCursorList<TwitterList> ListListMembershipsFor(int userId)
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists/memberships", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterCursorList<TwitterList> ListListMembershipsFor(int userId, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists/memberships", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterList> ListListMembershipsFor(int userId, bool filterToOwnedLists)
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists/memberships", FormatAsString, "?user_id=", userId, "&filter_to_owned_lists=", filterToOwnedLists);
		}

		public virtual TwitterCursorList<TwitterList> ListListMembershipsFor(int userId, bool filterToOwnedLists, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists/memberships", FormatAsString, "?user_id=", userId, "&filter_to_owned_lists=", filterToOwnedLists, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterList> ListListMembershipsFor(string screenName)
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists/memberships", FormatAsString, "?screen_name=", screenName);
		}

		public virtual TwitterCursorList<TwitterList> ListListMembershipsFor(string screenName, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists/memberships", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterList> ListListMembershipsFor(string screenName, bool filterToOwnedLists)
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists/memberships", FormatAsString, "?screen_name=", screenName, "&filter_to_owned_lists=", filterToOwnedLists);
		}

		public virtual TwitterCursorList<TwitterList> ListListMembershipsFor(string screenName, bool filterToOwnedLists, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists/memberships", FormatAsString, "?screen_name=", screenName, "&filter_to_owned_lists=", filterToOwnedLists, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterUser> ListListMembers(long listId)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/members", FormatAsString, "?list_id=", listId);
		}

		public virtual TwitterCursorList<TwitterUser> ListListMembers(long listId, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/members", FormatAsString, "?list_id=", listId, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterUser> ListListMembers(long listId, bool skipStatus)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/members", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus);
		}

		public virtual TwitterCursorList<TwitterUser> ListListMembers(long listId, bool skipStatus, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/members", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterUser> ListListMembers(string slug, int ownerId)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/members", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual TwitterCursorList<TwitterUser> ListListMembers(string slug, int ownerId, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/members", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterUser> ListListMembers(string slug, string ownerScreenName, bool skipStatus)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/members", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus);
		}

		public virtual TwitterCursorList<TwitterUser> ListListMembers(string slug, string ownerScreenName, bool skipStatus, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/members", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual TwitterUser AddListMember(long listId, int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/members/create", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual TwitterUser AddListMember(string slug, int ownerId, int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual TwitterUser AddListMember(string slug, string ownerScreenName, int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual TwitterUser AddListMember(long listId, string screenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/members/create", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual TwitterUser AddListMember(string slug, int ownerId, string screenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual TwitterUser AddListMember(string slug, string ownerScreenName, string screenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual TwitterUser RemoveListMember(long listId, int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/members/destroy", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual TwitterUser RemoveListMember(string slug, int ownerId, int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual TwitterUser RemoveListMember(string slug, string ownerScreenName, int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual TwitterUser RemoveListMember(long listId, string screenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/members/destroy", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual TwitterUser RemoveListMember(string slug, int ownerId, string screenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual TwitterUser RemoveListMember(string slug, string ownerScreenName, string screenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual TwitterCursorList<TwitterList> AddListMembers(long listId, string userId)
		{
			return WithHammock<TwitterCursorList<TwitterList>>(WebMethod.Post, "lists/members/create_all", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual TwitterCursorList<TwitterList> AddListMembersByScreenName(long listId, string screenName)
		{
			return WithHammock<TwitterCursorList<TwitterList>>(WebMethod.Post, "lists/members/create_all", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual TwitterCursorList<TwitterList> AddListMembers(string slug, int ownerId, string userId)
		{
			return WithHammock<TwitterCursorList<TwitterList>>(WebMethod.Post, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual TwitterCursorList<TwitterList> AddListMembersByScreenName(string slug, int ownerId, string screenName)
		{
			return WithHammock<TwitterCursorList<TwitterList>>(WebMethod.Post, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual TwitterCursorList<TwitterList> AddListMembers(string slug, string ownerScreenName, string userId)
		{
			return WithHammock<TwitterCursorList<TwitterList>>(WebMethod.Post, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual TwitterCursorList<TwitterList> AddListMembersByScreenName(string slug, string ownerScreenName, string screenName)
		{
			return WithHammock<TwitterCursorList<TwitterList>>(WebMethod.Post, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual TwitterUser VerifyListMembership(long listId, int userId)
		{
			return WithHammock<TwitterUser>("lists/members/show", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual TwitterUser VerifyListMembership(long listId, int userId, bool skipStatus)
		{
			return WithHammock<TwitterUser>("lists/members/show", FormatAsString, "?list_id=", listId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual TwitterUser VerifyListMembership(long listId, string screenName)
		{
			return WithHammock<TwitterUser>("lists/members/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual TwitterUser VerifyListMembership(long listId, string screenName, bool skipStatus)
		{
			return WithHammock<TwitterUser>("lists/members/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual TwitterUser VerifyListMembership(string slug, int ownerId, int userId)
		{
			return WithHammock<TwitterUser>("lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual TwitterUser VerifyListMembership(string slug, int ownerId, int userId, bool skipStatus)
		{
			return WithHammock<TwitterUser>("lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual TwitterUser VerifyListMembership(string slug, int ownerId, string screenName)
		{
			return WithHammock<TwitterUser>("lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual TwitterUser VerifyListMembership(string slug, int ownerId, string screenName, bool skipStatus)
		{
			return WithHammock<TwitterUser>("lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual TwitterUser VerifyListMembership(string slug, string ownerScreenName, int userId)
		{
			return WithHammock<TwitterUser>("lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual TwitterUser VerifyListMembership(string slug, string ownerScreenName, int userId, bool skipStatus)
		{
			return WithHammock<TwitterUser>("lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual TwitterUser VerifyListMembership(string slug, string ownerScreenName, string screenName)
		{
			return WithHammock<TwitterUser>("lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual TwitterUser VerifyListMembership(string slug, string ownerScreenName, string screenName, bool skipStatus)
		{
			return WithHammock<TwitterUser>("lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual IEnumerable<TwitterList> ListListSubscriptions()
		{
			return WithHammock<IEnumerable<TwitterList>>("lists/all", FormatAsString);
		}

		public virtual IEnumerable<TwitterList> ListListSubscriptionsFor(int userId)
		{
			return WithHammock<IEnumerable<TwitterList>>("lists/all", FormatAsString, "?user_id=", userId);
		}

		public virtual IEnumerable<TwitterList> ListListSubscriptionsFor(string screenName)
		{
			return WithHammock<IEnumerable<TwitterList>>("lists/all", FormatAsString, "?screen_name=", screenName);
		}

		public virtual TwitterCursorList<TwitterUser> ListListSubscribers(long listId)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/subscribers", FormatAsString, "?list_id=", listId);
		}

		public virtual TwitterCursorList<TwitterUser> ListListSubscribers(long listId, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/subscribers", FormatAsString, "?list_id=", listId, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterUser> ListListSubscribers(long listId, bool skipStatus)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/subscribers", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus);
		}

		public virtual TwitterCursorList<TwitterUser> ListListSubscribers(long listId, bool skipStatus, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/subscribers", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterUser> ListListSubscribers(string slug, int ownerId)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/subscribers", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual TwitterCursorList<TwitterUser> ListListSubscribers(string slug, int ownerId, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/subscribers", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterUser> ListListSubscribers(string slug, string ownerScreenName, bool skipStatus)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/subscribers", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus);
		}

		public virtual TwitterCursorList<TwitterUser> ListListSubscribers(string slug, string ownerScreenName, bool skipStatus, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/subscribers", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual TwitterUser FollowList(long listId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/create", FormatAsString, "?list_id=", listId);
		}

		public virtual TwitterUser FollowList(string slug, int ownerId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual TwitterUser FollowList(string slug, string ownerScreenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual TwitterUser UnfollowList(long listId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/destroy", FormatAsString, "?list_id=", listId);
		}

		public virtual TwitterUser UnfollowList(string slug, int ownerId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual TwitterUser UnfollowList(string slug, string ownerScreenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual TwitterUser VerifyListSubscription(long listId, int userId)
		{
			return WithHammock<TwitterUser>("lists/subscribers/show", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual TwitterUser VerifyListSubscription(long listId, int userId, bool skipStatus)
		{
			return WithHammock<TwitterUser>("lists/subscribers/show", FormatAsString, "?list_id=", listId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual TwitterUser VerifyListSubscription(long listId, string screenName)
		{
			return WithHammock<TwitterUser>("lists/subscribers/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual TwitterUser VerifyListSubscription(long listId, string screenName, bool skipStatus)
		{
			return WithHammock<TwitterUser>("lists/subscribers/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual TwitterUser VerifyListSubscription(string slug, int ownerId, int userId)
		{
			return WithHammock<TwitterUser>("lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual TwitterUser VerifyListSubscription(string slug, int ownerId, int userId, bool skipStatus)
		{
			return WithHammock<TwitterUser>("lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual TwitterUser VerifyListSubscription(string slug, int ownerId, string screenName)
		{
			return WithHammock<TwitterUser>("lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual TwitterUser VerifyListSubscription(string slug, int ownerId, string screenName, bool skipStatus)
		{
			return WithHammock<TwitterUser>("lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual TwitterUser VerifyListSubscription(string slug, string ownerScreenName, int userId)
		{
			return WithHammock<TwitterUser>("lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual TwitterUser VerifyListSubscription(string slug, string ownerScreenName, int userId, bool skipStatus)
		{
			return WithHammock<TwitterUser>("lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual TwitterUser VerifyListSubscription(string slug, string ownerScreenName, string screenName)
		{
			return WithHammock<TwitterUser>("lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual TwitterUser VerifyListSubscription(string slug, string ownerScreenName, string screenName, bool skipStatus)
		{
			return WithHammock<TwitterUser>("lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual TwitterUser FollowUserNotifications(string screenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "users/notifications/follow", FormatAsString, "?screen_name=", screenName);
		}

		public virtual TwitterUser FollowUserNotifications(int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "users/notifications/follow", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterUser UnfollowUserNotifications(int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "users/notifications/leave", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterUser UnfollowUserNotifications(string userScreenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "users/notifications/leave", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IEnumerable<TwitterSavedSearch> ListSavedSearches()
		{
			return WithHammock<IEnumerable<TwitterSavedSearch>>("saved_searches", FormatAsString);
		}

		public virtual TwitterSavedSearch GetSavedSearch(long id)
		{
			return WithHammock<TwitterSavedSearch>("saved_searches/show", FormatAsString, "?id=", id);
		}

		public virtual TwitterSavedSearch CreateSavedSearch(string query)
		{
			return WithHammock<TwitterSavedSearch>(WebMethod.Post, "saved_searches/create", FormatAsString, "?query=", query);
		}

		public virtual TwitterSavedSearch DeleteSavedSearch(long id)
		{
			return WithHammock<TwitterSavedSearch>(WebMethod.Delete, "saved_searches/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual TwitterSearchResult Search(string q)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?q=", q);
		}

		public virtual TwitterSearchResult Search(string q, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?q=", q, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult Search(string q, int rpp)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?q=", q, "&rpp=", rpp);
		}

		public virtual TwitterSearchResult Search(string q, int rpp, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult Search(string q, int page, int rpp)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual TwitterSearchResult Search(string q, int page, int rpp, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult SearchSince(long since_id, string q)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?since_id=", since_id, "&q=", q);
		}

		public virtual TwitterSearchResult SearchSince(long since_id, string q, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?since_id=", since_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult SearchSince(long since_id, string q, int rpp)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual TwitterSearchResult SearchSince(long since_id, string q, int rpp, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult SearchSince(long since_id, string q, int page, int rpp)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual TwitterSearchResult SearchSince(long since_id, string q, int page, int rpp, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult SearchBefore(long max_id, string q)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?max_id=", max_id, "&q=", q);
		}

		public virtual TwitterSearchResult SearchBefore(long max_id, string q, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?max_id=", max_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult SearchBefore(long max_id, string q, int rpp)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual TwitterSearchResult SearchBefore(long max_id, string q, int rpp, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult SearchBefore(long max_id, string q, int page, int rpp)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual TwitterSearchResult SearchBefore(long max_id, string q, int page, int rpp, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual TwitterUser ReportSpam(int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "report_spam", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterUser ReportSpam(string userScreenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "report_spam", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(int page, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId, int page, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId, int page, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimeline()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(int page, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId, int page, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId, int page, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count, bool includeRts)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMe()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMe(int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMe(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMeSince(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMeSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMeSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMeBefore(long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMeBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMeBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMe()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMe(int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMe(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMe(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMeSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMeSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMeBefore(long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMeBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMeBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMe()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMe(int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMe(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMeSince(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMeSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMeSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMeBefore(long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMeBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMeBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweets()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweets(int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweets(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweets(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsSince(long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual TwitterCurrentTrends ListCurrentTrends(int woeid)
		{
			return WithHammock<TwitterCurrentTrends>("trends/{woeid}", FormatAsString, "?woeid=", woeid);
		}

		public virtual TwitterCurrentTrends ListCurrentTrends(string exclude, int woeid)
		{
			return WithHammock<TwitterCurrentTrends>("trends/{woeid}", FormatAsString, "?exclude=", exclude, "&woeid=", woeid);
		}

		public virtual TwitterTrends ListDailyTrends()
		{
			return WithHammock<TwitterTrends>("trends/daily", FormatAsString);
		}

		public virtual TwitterTrends ListDailyTrends(DateTime date)
		{
			return WithHammock<TwitterTrends>("trends/daily", FormatAsString, "?date=", date);
		}

		public virtual TwitterTrends ListDailyTrends(string exclude)
		{
			return WithHammock<TwitterTrends>("trends/daily", FormatAsString, "?exclude=", exclude);
		}

		public virtual TwitterTrends ListDailyTrends(DateTime date, string exclude)
		{
			return WithHammock<TwitterTrends>("trends/daily", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual TwitterTrends ListWeeklyTrends()
		{
			return WithHammock<TwitterTrends>("trends/weekly", FormatAsString);
		}

		public virtual TwitterTrends ListWeeklyTrends(DateTime date)
		{
			return WithHammock<TwitterTrends>("trends/weekly", FormatAsString, "?date=", date);
		}

		public virtual TwitterTrends ListWeeklyTrends(string exclude)
		{
			return WithHammock<TwitterTrends>("trends/weekly", FormatAsString, "?exclude=", exclude);
		}

		public virtual TwitterTrends ListWeeklyTrends(DateTime date, string exclude)
		{
			return WithHammock<TwitterTrends>("trends/weekly", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual IEnumerable<WhereOnEarthLocation> ListAvailableTrendsLocations()
		{
			return WithHammock<IEnumerable<WhereOnEarthLocation>>("trends/available", FormatAsString);
		}

		public virtual IEnumerable<WhereOnEarthLocation> ListAvailableTrendsLocations(string lat)
		{
			return WithHammock<IEnumerable<WhereOnEarthLocation>>("trends/available", FormatAsString, "?lat=", lat);
		}

		public virtual IEnumerable<WhereOnEarthLocation> ListAvailableTrendsLocations(string lat, string @long)
		{
			return WithHammock<IEnumerable<WhereOnEarthLocation>>("trends/available", FormatAsString, "?lat=", lat, "&long=", @long);
		}

		public virtual TwitterLocalTrends ListLocalTrendsFor(long woeId)
		{
			return WithHammock<TwitterLocalTrends>("trends/{woe_id}", FormatAsString, "?woe_id=", woeId);
		}

		public virtual TwitterStatus GetTweet(long id)
		{
			return WithHammock<TwitterStatus>("statuses/show/{id}", FormatAsString, "?id=", id);
		}

		public virtual TwitterStatus SendTweet(string status)
		{
			return WithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status);
		}

		public virtual TwitterStatus SendTweet(string status, string lat, string @long)
		{
			return WithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&lat=", lat, "&long=", @long);
		}

		public virtual TwitterStatus SendTweet(string status, long inReplyToStatusId)
		{
			return WithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId);
		}

		public virtual TwitterStatus SendTweet(string status, long inReplyToStatusId, string lat, string @long)
		{
			return WithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId, "&lat=", lat, "&long=", @long);
		}

		public virtual TwitterStatus DeleteTweet(long id)
		{
			return WithHammock<TwitterStatus>(WebMethod.Delete, "statuses/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual TwitterStatus Retweet(long id)
		{
			return WithHammock<TwitterStatus>(WebMethod.Post, "statuses/retweet/{id}", FormatAsString, "?id=", id);
		}

		public virtual IEnumerable<TwitterStatus> Retweets(long id)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets/{id}", FormatAsString, "?id=", id);
		}

		public virtual IEnumerable<TwitterStatus> Retweets(long id, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets/{id}", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IEnumerable<TwitterUser> ListUsersWhoRetweeted(long id)
		{
			return WithHammock<IEnumerable<TwitterUser>>("statuses/{id}/retweeted_by", FormatAsString, "?id=", id);
		}

		public virtual IEnumerable<TwitterUser> ListUsersWhoRetweeted(long id, int count)
		{
			return WithHammock<IEnumerable<TwitterUser>>("statuses/{id}/retweeted_by", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IEnumerable<int> ListUserIdsWhoRetweeted(long id)
		{
			return WithHammock<IEnumerable<int>>("statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id);
		}

		public virtual IEnumerable<int> ListUserIdsWhoRetweeted(long id, int count)
		{
			return WithHammock<IEnumerable<int>>("statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual TwitterUser GetUserProfile()
		{
			return WithHammock<TwitterUser>("account/verify_credentials", FormatAsString);
		}

		public virtual TwitterUser GetUserProfileFor(string screenName)
		{
			return WithHammock<TwitterUser>("users/show", FormatAsString, "?screen_name=", screenName);
		}

		public virtual TwitterUser GetUserProfileFor(int id)
		{
			return WithHammock<TwitterUser>("users/show", FormatAsString, "?id=", id);
		}

		public virtual IEnumerable<TwitterUser> SearchForUser(string q)
		{
			return WithHammock<IEnumerable<TwitterUser>>("users/search", FormatAsString, "?q=", q);
		}

		public virtual IEnumerable<TwitterUser> SearchForUser(string q, int perPage)
		{
			return WithHammock<IEnumerable<TwitterUser>>("users/search", FormatAsString, "?q=", q, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterUser> SearchForUser(string q, int page, int perPage)
		{
			return WithHammock<IEnumerable<TwitterUser>>("users/search", FormatAsString, "?q=", q, "&page=", page, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterUser> ListUserProfilesFor(string userId)
		{
			return WithHammock<IEnumerable<TwitterUser>>("users/lookup", FormatAsString, "?user_id=", userId);
		}

		public virtual byte[] GetProfileImageFor(string screenName)
		{
			return WithHammock<byte[]>("users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName);
		}

		public virtual byte[] GetProfileImageFor(string screenName, TwitterProfileImageSize size)
		{
			return WithHammock<byte[]>("users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName, "&size=", size);
		}

		public virtual IEnumerable<TwitterUserSuggestions> ListSuggestedUserCategories()
		{
			return WithHammock<IEnumerable<TwitterUserSuggestions>>("users/suggestions", FormatAsString);
		}

		public virtual TwitterUserSuggestions ListSuggestedUsers(string categorySlug)
		{
			return WithHammock<TwitterUserSuggestions>("/users/suggestions/{category_slug}", FormatAsString, "?category_slug=", categorySlug);
		}

		#endregion
#endif

#if !WINDOWS_PHONE
		#region Asynchronous Methods (with IAsyncResult)
		public virtual IAsyncResult VerifyCredentials(Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "account/verify_credentials", FormatAsString);
		}

		public virtual IAsyncResult GetRateLimitStatus(Action<TwitterRateLimitStatus, TwitterResponse> action)
		{
			return WithHammock(action, "account/rate_limit_status", FormatAsString);
		}

		public virtual IAsyncResult EndSession(Action<TwitterError, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/end_session", FormatAsString);
		}

		public virtual IAsyncResult UpdateDeliveryDevice(TwitterDeliveryDevice device, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "account/update_delivery_device", FormatAsString, "?device=", device);
		}

		public virtual IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, string sidebarBorderColor, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor, "&sidebar_border_color=", sidebarBorderColor);
		}

		public virtual IAsyncResult UpdateProfileColors(string backgroundColor, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor);
		}

		public virtual IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor);
		}

		public virtual IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, string linkColor, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor);
		}

		public virtual IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor);
		}

		public virtual IAsyncResult UpdateProfileImage(string path, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile_image", FormatAsString, "?path=", path);
		}

		public virtual IAsyncResult UpdateProfileBackgroundImage(string path, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile_background_image", FormatAsString, "?path=", path);
		}

		public virtual IAsyncResult UpdateProfile(string name, string description, string email, string url, string location, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile", FormatAsString, "?name=", name, "&description=", description, "&email=", email, "&url=", url, "&location=", location);
		}

		public virtual IAsyncResult GetConfiguration(Action<TwitterConfiguration, TwitterResponse> action)
		{
			return WithHammock(action, "help/configuration", FormatAsString);
		}

		public virtual IAsyncResult BlockUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "blocks/create", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BlockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "blocks/create", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult UnblockUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "blocks/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult UnblockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "blocks/destroy", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult VerifyBlocking(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "blocks/exists", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult VerifyBlocking(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "blocks/exists", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult ListBlockedUsers(Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "blocks/blocking", FormatAsString);
		}

		public virtual IAsyncResult ListBlockedUsers(int page, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "blocks/blocking", FormatAsString, "?page=", page);
		}

		public virtual IAsyncResult ListBlockedUserIds(Action<IEnumerable<int>, TwitterResponse> action)
		{
			return WithHammock(action, "blocks/blocking/ids", FormatAsString);
		}

		public virtual IAsyncResult ListDirectMessagesReceived(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString);
		}

		public virtual IAsyncResult ListDirectMessagesReceived(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesReceived(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesReceivedSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListDirectMessagesReceivedSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesReceivedSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesReceivedBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListDirectMessagesReceivedBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesReceivedBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesSent(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString);
		}

		public virtual IAsyncResult ListDirectMessagesSent(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesSent(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesSentSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListDirectMessagesSentSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesSentSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesSentBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListDirectMessagesSentBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesSentBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult DeleteDirectMessage(long id, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult DeleteDirectMessage(int id, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult SendDirectMessage(int userId, string text, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "direct_messages/new", FormatAsString, "?user_id=", userId, "&text=", text);
		}

		public virtual IAsyncResult SendDirectMessage(string screenName, string text, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "direct_messages/new", FormatAsString, "?screen_name=", screenName, "&text=", text);
		}

		public virtual IAsyncResult ListFavoriteTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites", FormatAsString);
		}

		public virtual IAsyncResult ListFavoriteTweets(int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites", FormatAsString, "?page=", page);
		}

		public virtual IAsyncResult ListFavoriteTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListFavoriteTweetsFor(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult ListFavoriteTweetsFor(int userId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page);
		}

		public virtual IAsyncResult ListFavoriteTweetsFor(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListFavoriteTweetsFor(string userScreenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult ListFavoriteTweetsFor(string userScreenName, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page);
		}

		public virtual IAsyncResult ListFavoriteTweetsFor(string userScreenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult FavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "favorites/create/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult UnfavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "favorites/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult ListFriendIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "friends/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListFriendIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "friends/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListFollowerIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "followers/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListFollowerIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "followers/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult FollowUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "friendships/create", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult FollowUser(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "friendships/create", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult UnfollowUser(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "friendships/destroy", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult UnfollowUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "friendships/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult GetIncomingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "friendships/incoming", FormatAsString);
		}

		public virtual IAsyncResult GetIncomingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "friendships/incoming", FormatAsString, "?cursor=", cursor);
		}

		public virtual IAsyncResult GetOutgoingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "friendships/outgoing", FormatAsString);
		}

		public virtual IAsyncResult GetOutgoingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "friendships/outgoing", FormatAsString, "?cursor=", cursor);
		}

		public virtual IAsyncResult GetFriendshipInfo(string sourceScreenName, string targetScreenName, Action<TwitterFriendship, TwitterResponse> action)
		{
			return WithHammock(action, "friendships/show", FormatAsString, "?source_screen_name=", sourceScreenName, "&target_screen_name=", targetScreenName);
		}

		public virtual IAsyncResult GetFriendshipInfo(int sourceId, int targetId, Action<TwitterFriendship, TwitterResponse> action)
		{
			return WithHammock(action, "friendships/show", FormatAsString, "?source_id=", sourceId, "&target_id=", targetId);
		}

		public virtual IAsyncResult CreateList(string name, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/create", FormatAsString, "?name=", name);
		}

		public virtual IAsyncResult CreateList(string name, string description, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/create", FormatAsString, "?name=", name, "&description=", description);
		}

		public virtual IAsyncResult CreateList(string name, string description, string mode, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/create", FormatAsString, "?name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual IAsyncResult UpdateList(long listId, string name, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?list_id=", listId, "&name=", name);
		}

		public virtual IAsyncResult UpdateList(long listId, string name, string description, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?list_id=", listId, "&name=", name, "&description=", description);
		}

		public virtual IAsyncResult UpdateList(long listId, string name, string description, string mode, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?list_id=", listId, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual IAsyncResult UpdateList(string slug, int ownerId, string name, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&name=", name);
		}

		public virtual IAsyncResult UpdateList(string slug, int ownerId, string name, string description, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&name=", name, "&description=", description);
		}

		public virtual IAsyncResult UpdateList(string slug, int ownerId, string name, string description, string mode, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual IAsyncResult UpdateList(string slug, string ownerScreenName, string name, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&name=", name);
		}

		public virtual IAsyncResult UpdateList(string slug, string ownerScreenName, string name, string description, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&name=", name, "&description=", description);
		}

		public virtual IAsyncResult UpdateList(string slug, string ownerScreenName, string name, string description, string mode, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual IAsyncResult ListLists(Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists", FormatAsString);
		}

		public virtual IAsyncResult ListLists(long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists", FormatAsString, "?cursor=", cursor);
		}

		public virtual IAsyncResult ListListsFor(int userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult ListListsFor(int userId, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListListsFor(string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult ListListsFor(string screenName, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult GetList(int userId, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(action, "lists/show", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult GetList(string slug, int ownerId, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(action, "lists/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual IAsyncResult GetList(string slug, string ownerScreenName, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(action, "lists/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual IAsyncResult DeleteList(long listId, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/destroy", FormatAsString, "?list_id=", listId);
		}

		public virtual IAsyncResult DeleteList(string slug, int ownerId, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/destroy", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual IAsyncResult DeleteList(string slug, string ownerScreenName, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/destroy", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual IAsyncResult ListTweetsOnList(long listId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId);
		}

		public virtual IAsyncResult ListTweetsOnList(long listId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnList(long listId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnList(long listId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnList(long listId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnList(long listId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnList(string slug, int ownerId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual IAsyncResult ListTweetsOnList(string slug, int ownerId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnList(string slug, int ownerId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnList(string slug, int ownerId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnList(string slug, int ownerId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnList(string slug, int ownerId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnList(string slug, string ownerScreenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual IAsyncResult ListTweetsOnList(string slug, string ownerScreenName, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnList(string slug, string ownerScreenName, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnList(string slug, string ownerScreenName, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnList(string slug, string ownerScreenName, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnList(string slug, string ownerScreenName, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListSince(long listId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId);
		}

		public virtual IAsyncResult ListTweetsOnListSince(long listId, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListSince(long listId, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListSince(long listId, long sinceId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListSince(long listId, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListSince(long listId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListSince(string slug, int ownerId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId);
		}

		public virtual IAsyncResult ListTweetsOnListSince(string slug, int ownerId, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListSince(string slug, int ownerId, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListSince(string slug, int ownerId, long sinceId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListSince(string slug, int ownerId, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListSince(string slug, int ownerId, long sinceId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId);
		}

		public virtual IAsyncResult ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(long listId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(long listId, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(long listId, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(long listId, long maxId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(long listId, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(long listId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(string slug, int ownerId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(string slug, int ownerId, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(string slug, int ownerId, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(string slug, int ownerId, long maxId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(string slug, int ownerId, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(string slug, int ownerId, long maxId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListListMemberships(Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/memberships", FormatAsString);
		}

		public virtual IAsyncResult ListListMembershipsFor(int userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/memberships", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult ListListMembershipsFor(int userId, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/memberships", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListListMembershipsFor(int userId, bool filterToOwnedLists, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/memberships", FormatAsString, "?user_id=", userId, "&filter_to_owned_lists=", filterToOwnedLists);
		}

		public virtual IAsyncResult ListListMembershipsFor(int userId, bool filterToOwnedLists, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/memberships", FormatAsString, "?user_id=", userId, "&filter_to_owned_lists=", filterToOwnedLists, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListListMembershipsFor(string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/memberships", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult ListListMembershipsFor(string screenName, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/memberships", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListListMembershipsFor(string screenName, bool filterToOwnedLists, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/memberships", FormatAsString, "?screen_name=", screenName, "&filter_to_owned_lists=", filterToOwnedLists);
		}

		public virtual IAsyncResult ListListMembershipsFor(string screenName, bool filterToOwnedLists, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/memberships", FormatAsString, "?screen_name=", screenName, "&filter_to_owned_lists=", filterToOwnedLists, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListListMembers(long listId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members", FormatAsString, "?list_id=", listId);
		}

		public virtual IAsyncResult ListListMembers(long listId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members", FormatAsString, "?list_id=", listId, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListListMembers(long listId, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult ListListMembers(long listId, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListListMembers(string slug, int ownerId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual IAsyncResult ListListMembers(string slug, int ownerId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListListMembers(string slug, string ownerScreenName, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult ListListMembers(string slug, string ownerScreenName, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual IAsyncResult AddListMember(long listId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/create", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual IAsyncResult AddListMember(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual IAsyncResult AddListMember(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual IAsyncResult AddListMember(long listId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/create", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult AddListMember(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult AddListMember(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual IAsyncResult RemoveListMember(long listId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual IAsyncResult RemoveListMember(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual IAsyncResult RemoveListMember(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual IAsyncResult RemoveListMember(long listId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult RemoveListMember(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult RemoveListMember(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual IAsyncResult AddListMembers(long listId, string userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/create_all", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual IAsyncResult AddListMembersByScreenName(long listId, string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/create_all", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult AddListMembers(string slug, int ownerId, string userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual IAsyncResult AddListMembersByScreenName(string slug, int ownerId, string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult AddListMembers(string slug, string ownerScreenName, string userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual IAsyncResult AddListMembersByScreenName(string slug, string ownerScreenName, string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual IAsyncResult VerifyListMembership(long listId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members/show", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual IAsyncResult VerifyListMembership(long listId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members/show", FormatAsString, "?list_id=", listId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult VerifyListMembership(long listId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult VerifyListMembership(long listId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult VerifyListMembership(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual IAsyncResult VerifyListMembership(string slug, int ownerId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult VerifyListMembership(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult VerifyListMembership(string slug, int ownerId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult VerifyListMembership(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual IAsyncResult VerifyListMembership(string slug, string ownerScreenName, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult VerifyListMembership(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual IAsyncResult VerifyListMembership(string slug, string ownerScreenName, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult ListListSubscriptions(Action<IEnumerable<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/all", FormatAsString);
		}

		public virtual IAsyncResult ListListSubscriptionsFor(int userId, Action<IEnumerable<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/all", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult ListListSubscriptionsFor(string screenName, Action<IEnumerable<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/all", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult ListListSubscribers(long listId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers", FormatAsString, "?list_id=", listId);
		}

		public virtual IAsyncResult ListListSubscribers(long listId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers", FormatAsString, "?list_id=", listId, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListListSubscribers(long listId, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult ListListSubscribers(long listId, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListListSubscribers(string slug, int ownerId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual IAsyncResult ListListSubscribers(string slug, int ownerId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListListSubscribers(string slug, string ownerScreenName, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult ListListSubscribers(string slug, string ownerScreenName, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual IAsyncResult FollowList(long listId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/subscribers/create", FormatAsString, "?list_id=", listId);
		}

		public virtual IAsyncResult FollowList(string slug, int ownerId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual IAsyncResult FollowList(string slug, string ownerScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual IAsyncResult UnfollowList(long listId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/subscribers/destroy", FormatAsString, "?list_id=", listId);
		}

		public virtual IAsyncResult UnfollowList(string slug, int ownerId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual IAsyncResult UnfollowList(string slug, string ownerScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual IAsyncResult VerifyListSubscription(long listId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers/show", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual IAsyncResult VerifyListSubscription(long listId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers/show", FormatAsString, "?list_id=", listId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult VerifyListSubscription(long listId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult VerifyListSubscription(long listId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult VerifyListSubscription(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual IAsyncResult VerifyListSubscription(string slug, int ownerId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult VerifyListSubscription(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult VerifyListSubscription(string slug, int ownerId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult VerifyListSubscription(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual IAsyncResult VerifyListSubscription(string slug, string ownerScreenName, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult VerifyListSubscription(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual IAsyncResult VerifyListSubscription(string slug, string ownerScreenName, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult FollowUserNotifications(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "users/notifications/follow", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult FollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "users/notifications/follow", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult UnfollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "users/notifications/leave", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult UnfollowUserNotifications(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "users/notifications/leave", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult ListSavedSearches(Action<IEnumerable<TwitterSavedSearch>, TwitterResponse> action)
		{
			return WithHammock(action, "saved_searches", FormatAsString);
		}

		public virtual IAsyncResult GetSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action)
		{
			return WithHammock(action, "saved_searches/show", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult CreateSavedSearch(string query, Action<TwitterSavedSearch, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "saved_searches/create", FormatAsString, "?query=", query);
		}

		public virtual IAsyncResult DeleteSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "saved_searches/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult Search(string q, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?q=", q);
		}

		public virtual IAsyncResult Search(string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?q=", q, "&result_type=", resultType);
		}

		public virtual IAsyncResult Search(string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?q=", q, "&rpp=", rpp);
		}

		public virtual IAsyncResult Search(string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult Search(string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual IAsyncResult Search(string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult SearchSince(long since_id, string q, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q);
		}

		public virtual IAsyncResult SearchSince(long since_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual IAsyncResult SearchSince(long since_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual IAsyncResult SearchSince(long since_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult SearchSince(long since_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual IAsyncResult SearchSince(long since_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult SearchBefore(long max_id, string q, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q);
		}

		public virtual IAsyncResult SearchBefore(long max_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual IAsyncResult SearchBefore(long max_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual IAsyncResult SearchBefore(long max_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult SearchBefore(long max_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual IAsyncResult SearchBefore(long max_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult ReportSpam(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "report_spam", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult ReportSpam(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "report_spam", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimeline(bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimeline(int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimeline(int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnUserTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString);
		}

		public virtual IAsyncResult ListTweetsOnUserTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListTweetsOnUserTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnUserTimeline(bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnUserTimeline(int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnUserTimeline(int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult ListTweetsMentioningMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString);
		}

		public virtual IAsyncResult ListTweetsMentioningMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListTweetsMentioningMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsMentioningMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListTweetsMentioningMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsMentioningMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsMentioningMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListTweetsMentioningMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsMentioningMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsByMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString);
		}

		public virtual IAsyncResult ListRetweetsByMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListRetweetsByMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsByMe(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListRetweetsByMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsByMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsByMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListRetweetsByMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsByMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsToMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString);
		}

		public virtual IAsyncResult ListRetweetsToMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListRetweetsToMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsToMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListRetweetsToMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsToMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsToMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListRetweetsToMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsToMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweets(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweets(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweetsSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweetsSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweetsSince(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweetsBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweetsBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListCurrentTrends(int woeid, Action<TwitterCurrentTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/{woeid}", FormatAsString, "?woeid=", woeid);
		}

		public virtual IAsyncResult ListCurrentTrends(string exclude, int woeid, Action<TwitterCurrentTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/{woeid}", FormatAsString, "?exclude=", exclude, "&woeid=", woeid);
		}

		public virtual IAsyncResult ListDailyTrends(Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/daily", FormatAsString);
		}

		public virtual IAsyncResult ListDailyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/daily", FormatAsString, "?date=", date);
		}

		public virtual IAsyncResult ListDailyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/daily", FormatAsString, "?exclude=", exclude);
		}

		public virtual IAsyncResult ListDailyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/daily", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual IAsyncResult ListWeeklyTrends(Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/weekly", FormatAsString);
		}

		public virtual IAsyncResult ListWeeklyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/weekly", FormatAsString, "?date=", date);
		}

		public virtual IAsyncResult ListWeeklyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/weekly", FormatAsString, "?exclude=", exclude);
		}

		public virtual IAsyncResult ListWeeklyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/weekly", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual IAsyncResult ListAvailableTrendsLocations(Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action)
		{
			return WithHammock(action, "trends/available", FormatAsString);
		}

		public virtual IAsyncResult ListAvailableTrendsLocations(string lat, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action)
		{
			return WithHammock(action, "trends/available", FormatAsString, "?lat=", lat);
		}

		public virtual IAsyncResult ListAvailableTrendsLocations(string lat, string @long, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action)
		{
			return WithHammock(action, "trends/available", FormatAsString, "?lat=", lat, "&long=", @long);
		}

		public virtual IAsyncResult ListLocalTrendsFor(long woeId, Action<TwitterLocalTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/{woe_id}", FormatAsString, "?woe_id=", woeId);
		}

		public virtual IAsyncResult GetTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/show/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult SendTweet(string status, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status);
		}

		public virtual IAsyncResult SendTweet(string status, string lat, string @long, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status, "&lat=", lat, "&long=", @long);
		}

		public virtual IAsyncResult SendTweet(string status, long inReplyToStatusId, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId);
		}

		public virtual IAsyncResult SendTweet(string status, long inReplyToStatusId, string lat, string @long, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId, "&lat=", lat, "&long=", @long);
		}

		public virtual IAsyncResult DeleteTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "statuses/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult Retweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "statuses/retweet/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult Retweets(long id, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult Retweets(long id, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets/{id}", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IAsyncResult ListUsersWhoRetweeted(long id, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/{id}/retweeted_by", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult ListUsersWhoRetweeted(long id, int count, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/{id}/retweeted_by", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IAsyncResult ListUserIdsWhoRetweeted(long id, Action<IEnumerable<int>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult ListUserIdsWhoRetweeted(long id, int count, Action<IEnumerable<int>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IAsyncResult GetUserProfile(Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "account/verify_credentials", FormatAsString);
		}

		public virtual IAsyncResult GetUserProfileFor(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "users/show", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult GetUserProfileFor(int id, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "users/show", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult SearchForUser(string q, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "users/search", FormatAsString, "?q=", q);
		}

		public virtual IAsyncResult SearchForUser(string q, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "users/search", FormatAsString, "?q=", q, "&per_page=", perPage);
		}

		public virtual IAsyncResult SearchForUser(string q, int page, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "users/search", FormatAsString, "?q=", q, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListUserProfilesFor(string userId, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "users/lookup", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult GetProfileImageFor(string screenName, Action<byte[], TwitterResponse> action)
		{
			return WithHammock(action, "users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult GetProfileImageFor(string screenName, TwitterProfileImageSize size, Action<byte[], TwitterResponse> action)
		{
			return WithHammock(action, "users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName, "&size=", size);
		}

		public virtual IAsyncResult ListSuggestedUserCategories(Action<IEnumerable<TwitterUserSuggestions>, TwitterResponse> action)
		{
			return WithHammock(action, "users/suggestions", FormatAsString);
		}

		public virtual IAsyncResult ListSuggestedUsers(string categorySlug, Action<TwitterUserSuggestions, TwitterResponse> action)
		{
			return WithHammock(action, "/users/suggestions/{category_slug}", FormatAsString, "?category_slug=", categorySlug);
		}

		#endregion
#endif

#if !WINDOWS_PHONE
		#region Asynchronous Methods (with Begin/End pattern)
		public virtual IAsyncResult BeginVerifyCredentials()
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "account/verify_credentials", FormatAsString);
		}

		public virtual IAsyncResult BeginGetRateLimitStatus()
		{
			return BeginWithHammock<TwitterRateLimitStatus>(WebMethod.Get, "account/rate_limit_status", FormatAsString);
		}

		public virtual IAsyncResult BeginEndSession()
		{
			return BeginWithHammock<TwitterError>(WebMethod.Post, "account/end_session", FormatAsString);
		}

		public virtual IAsyncResult BeginUpdateDeliveryDevice(TwitterDeliveryDevice device)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "account/update_delivery_device", FormatAsString, "?device=", device);
		}

		public virtual IAsyncResult BeginUpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, string sidebarBorderColor)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor, "&sidebar_border_color=", sidebarBorderColor);
		}

		public virtual IAsyncResult BeginUpdateProfileColors(string backgroundColor)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor);
		}

		public virtual IAsyncResult BeginUpdateProfileColors(string backgroundColor, string textColor)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor);
		}

		public virtual IAsyncResult BeginUpdateProfileColors(string backgroundColor, string textColor, string linkColor)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor);
		}

		public virtual IAsyncResult BeginUpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor);
		}

		public virtual IAsyncResult BeginUpdateProfileImage(string path)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_image", FormatAsString, "?path=", path);
		}

		public virtual IAsyncResult BeginUpdateProfileBackgroundImage(string path)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_background_image", FormatAsString, "?path=", path);
		}

		public virtual IAsyncResult BeginUpdateProfile(string name, string description, string email, string url, string location)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile", FormatAsString, "?name=", name, "&description=", description, "&email=", email, "&url=", url, "&location=", location);
		}

		public virtual IAsyncResult BeginGetConfiguration()
		{
			return BeginWithHammock<TwitterConfiguration>(WebMethod.Get, "help/configuration", FormatAsString);
		}

		public virtual IAsyncResult BeginBlockUser(int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "blocks/create", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginBlockUser(string userScreenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "blocks/create", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult BeginUnblockUser(int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Delete, "blocks/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginUnblockUser(string userScreenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Delete, "blocks/destroy", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult BeginVerifyBlocking(int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "blocks/exists", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginVerifyBlocking(string userScreenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "blocks/exists", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult BeginListBlockedUsers()
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "blocks/blocking", FormatAsString);
		}

		public virtual IAsyncResult BeginListBlockedUsers(int page)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "blocks/blocking", FormatAsString, "?page=", page);
		}

		public virtual IAsyncResult BeginListBlockedUserIds()
		{
			return BeginWithHammock<IEnumerable<int>>(WebMethod.Get, "blocks/blocking/ids", FormatAsString);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceived()
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceived(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceived(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceivedSince(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceivedSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceivedSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceivedBefore(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceivedBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceivedBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesSent()
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString);
		}

		public virtual IAsyncResult BeginListDirectMessagesSent(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesSent(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesSentSince(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListDirectMessagesSentSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesSentSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesSentBefore(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListDirectMessagesSentBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesSentBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginDeleteDirectMessage(long id)
		{
			return BeginWithHammock<TwitterDirectMessage>(WebMethod.Delete, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginDeleteDirectMessage(int id)
		{
			return BeginWithHammock<TwitterDirectMessage>(WebMethod.Delete, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginSendDirectMessage(int userId, string text)
		{
			return BeginWithHammock<TwitterDirectMessage>(WebMethod.Post, "direct_messages/new", FormatAsString, "?user_id=", userId, "&text=", text);
		}

		public virtual IAsyncResult BeginSendDirectMessage(string screenName, string text)
		{
			return BeginWithHammock<TwitterDirectMessage>(WebMethod.Post, "direct_messages/new", FormatAsString, "?screen_name=", screenName, "&text=", text);
		}

		public virtual IAsyncResult BeginListFavoriteTweets()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites", FormatAsString);
		}

		public virtual IAsyncResult BeginListFavoriteTweets(int page)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites", FormatAsString, "?page=", page);
		}

		public virtual IAsyncResult BeginListFavoriteTweets(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListFavoriteTweetsFor(int userId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginListFavoriteTweetsFor(int userId, int page)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page);
		}

		public virtual IAsyncResult BeginListFavoriteTweetsFor(int userId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListFavoriteTweetsFor(string userScreenName)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult BeginListFavoriteTweetsFor(string userScreenName, int page)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page);
		}

		public virtual IAsyncResult BeginListFavoriteTweetsFor(string userScreenName, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginFavoriteTweet(long id)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Post, "favorites/create/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginUnfavoriteTweet(long id)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Delete, "favorites/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginListFriendIdsOf(string screenName, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "friends/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListFriendIdsOf(int userId, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "friends/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListFollowerIdsOf(int userId, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "followers/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListFollowerIdsOf(string screenName, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "followers/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginFollowUser(int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "friendships/create", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginFollowUser(string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "friendships/create", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginUnfollowUser(string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Delete, "friendships/destroy", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginUnfollowUser(int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Delete, "friendships/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginGetIncomingFriendRequests()
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "friendships/incoming", FormatAsString);
		}

		public virtual IAsyncResult BeginGetIncomingFriendRequests(long cursor)
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "friendships/incoming", FormatAsString, "?cursor=", cursor);
		}

		public virtual IAsyncResult BeginGetOutgoingFriendRequests()
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "friendships/outgoing", FormatAsString);
		}

		public virtual IAsyncResult BeginGetOutgoingFriendRequests(long cursor)
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "friendships/outgoing", FormatAsString, "?cursor=", cursor);
		}

		public virtual IAsyncResult BeginGetFriendshipInfo(string sourceScreenName, string targetScreenName)
		{
			return BeginWithHammock<TwitterFriendship>(WebMethod.Get, "friendships/show", FormatAsString, "?source_screen_name=", sourceScreenName, "&target_screen_name=", targetScreenName);
		}

		public virtual IAsyncResult BeginGetFriendshipInfo(int sourceId, int targetId)
		{
			return BeginWithHammock<TwitterFriendship>(WebMethod.Get, "friendships/show", FormatAsString, "?source_id=", sourceId, "&target_id=", targetId);
		}

		public virtual IAsyncResult BeginCreateList(string name)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/create", FormatAsString, "?name=", name);
		}

		public virtual IAsyncResult BeginCreateList(string name, string description)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/create", FormatAsString, "?name=", name, "&description=", description);
		}

		public virtual IAsyncResult BeginCreateList(string name, string description, string mode)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/create", FormatAsString, "?name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual IAsyncResult BeginUpdateList(long listId, string name)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?list_id=", listId, "&name=", name);
		}

		public virtual IAsyncResult BeginUpdateList(long listId, string name, string description)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?list_id=", listId, "&name=", name, "&description=", description);
		}

		public virtual IAsyncResult BeginUpdateList(long listId, string name, string description, string mode)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?list_id=", listId, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual IAsyncResult BeginUpdateList(string slug, int ownerId, string name)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&name=", name);
		}

		public virtual IAsyncResult BeginUpdateList(string slug, int ownerId, string name, string description)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&name=", name, "&description=", description);
		}

		public virtual IAsyncResult BeginUpdateList(string slug, int ownerId, string name, string description, string mode)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual IAsyncResult BeginUpdateList(string slug, string ownerScreenName, string name)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&name=", name);
		}

		public virtual IAsyncResult BeginUpdateList(string slug, string ownerScreenName, string name, string description)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&name=", name, "&description=", description);
		}

		public virtual IAsyncResult BeginUpdateList(string slug, string ownerScreenName, string name, string description, string mode)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/update", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual IAsyncResult BeginListLists()
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists", FormatAsString);
		}

		public virtual IAsyncResult BeginListLists(long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists", FormatAsString, "?cursor=", cursor);
		}

		public virtual IAsyncResult BeginListListsFor(int userId)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginListListsFor(int userId, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListListsFor(string screenName)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginListListsFor(string screenName, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginGetList(int userId)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Get, "lists/show", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginGetList(string slug, int ownerId)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Get, "lists/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual IAsyncResult BeginGetList(string slug, string ownerScreenName)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Get, "lists/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual IAsyncResult BeginDeleteList(long listId)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/destroy", FormatAsString, "?list_id=", listId);
		}

		public virtual IAsyncResult BeginDeleteList(string slug, int ownerId)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/destroy", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual IAsyncResult BeginDeleteList(string slug, string ownerScreenName)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/destroy", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual IAsyncResult BeginListTweetsOnList(long listId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId);
		}

		public virtual IAsyncResult BeginListTweetsOnList(long listId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnList(long listId, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnList(long listId, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnList(long listId, int page, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnList(long listId, int page, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnList(string slug, int ownerId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual IAsyncResult BeginListTweetsOnList(string slug, int ownerId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnList(string slug, int ownerId, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnList(string slug, int ownerId, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnList(string slug, int ownerId, int page, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnList(string slug, int ownerId, int page, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnList(string slug, string ownerScreenName)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual IAsyncResult BeginListTweetsOnList(string slug, string ownerScreenName, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnList(string slug, string ownerScreenName, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnList(string slug, string ownerScreenName, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnList(string slug, string ownerScreenName, int page, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnList(string slug, string ownerScreenName, int page, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(long listId, long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(long listId, long sinceId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(long listId, long sinceId, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(long listId, long sinceId, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(long listId, long sinceId, int page, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(long listId, int page, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(string slug, int ownerId, long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(string slug, int ownerId, long sinceId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(string slug, int ownerId, long sinceId, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(string slug, int ownerId, long sinceId, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(string slug, int ownerId, long sinceId, int page, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(string slug, int ownerId, long sinceId, int page, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(string slug, string ownerScreenName, long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int page, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int page, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(long listId, long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(long listId, long maxId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(long listId, long maxId, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(long listId, long maxId, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(long listId, long maxId, int page, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(long listId, int page, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(string slug, int ownerId, long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(string slug, int ownerId, long maxId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(string slug, int ownerId, long maxId, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(string slug, int ownerId, long maxId, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(string slug, int ownerId, long maxId, int page, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(string slug, int ownerId, long maxId, int page, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(string slug, string ownerScreenName, long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int page, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int page, int perPage, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListListMemberships()
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists/memberships", FormatAsString);
		}

		public virtual IAsyncResult BeginListListMembershipsFor(int userId)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists/memberships", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginListListMembershipsFor(int userId, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists/memberships", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListListMembershipsFor(int userId, bool filterToOwnedLists)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists/memberships", FormatAsString, "?user_id=", userId, "&filter_to_owned_lists=", filterToOwnedLists);
		}

		public virtual IAsyncResult BeginListListMembershipsFor(int userId, bool filterToOwnedLists, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists/memberships", FormatAsString, "?user_id=", userId, "&filter_to_owned_lists=", filterToOwnedLists, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListListMembershipsFor(string screenName)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists/memberships", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginListListMembershipsFor(string screenName, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists/memberships", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListListMembershipsFor(string screenName, bool filterToOwnedLists)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists/memberships", FormatAsString, "?screen_name=", screenName, "&filter_to_owned_lists=", filterToOwnedLists);
		}

		public virtual IAsyncResult BeginListListMembershipsFor(string screenName, bool filterToOwnedLists, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists/memberships", FormatAsString, "?screen_name=", screenName, "&filter_to_owned_lists=", filterToOwnedLists, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListListMembers(long listId)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/members", FormatAsString, "?list_id=", listId);
		}

		public virtual IAsyncResult BeginListListMembers(long listId, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/members", FormatAsString, "?list_id=", listId, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListListMembers(long listId, bool skipStatus)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/members", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginListListMembers(long listId, bool skipStatus, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/members", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListListMembers(string slug, int ownerId)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/members", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual IAsyncResult BeginListListMembers(string slug, int ownerId, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/members", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListListMembers(string slug, string ownerScreenName, bool skipStatus)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/members", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginListListMembers(string slug, string ownerScreenName, bool skipStatus, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/members", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginAddListMember(long listId, int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/members/create", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginAddListMember(string slug, int ownerId, int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginAddListMember(string slug, string ownerScreenName, int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginAddListMember(long listId, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/members/create", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginAddListMember(string slug, int ownerId, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginAddListMember(string slug, string ownerScreenName, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginRemoveListMember(long listId, int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/members/destroy", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginRemoveListMember(string slug, int ownerId, int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginRemoveListMember(string slug, string ownerScreenName, int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginRemoveListMember(long listId, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/members/destroy", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginRemoveListMember(string slug, int ownerId, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginRemoveListMember(string slug, string ownerScreenName, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginAddListMembers(long listId, string userId)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Post, "lists/members/create_all", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginAddListMembersByScreenName(long listId, string screenName)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Post, "lists/members/create_all", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginAddListMembers(string slug, int ownerId, string userId)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Post, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginAddListMembersByScreenName(string slug, int ownerId, string screenName)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Post, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginAddListMembers(string slug, string ownerScreenName, string userId)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Post, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginAddListMembersByScreenName(string slug, string ownerScreenName, string screenName)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Post, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginVerifyListMembership(long listId, int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/members/show", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginVerifyListMembership(long listId, int userId, bool skipStatus)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/members/show", FormatAsString, "?list_id=", listId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginVerifyListMembership(long listId, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/members/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginVerifyListMembership(long listId, string screenName, bool skipStatus)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/members/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginVerifyListMembership(string slug, int ownerId, int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginVerifyListMembership(string slug, int ownerId, int userId, bool skipStatus)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginVerifyListMembership(string slug, int ownerId, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginVerifyListMembership(string slug, int ownerId, string screenName, bool skipStatus)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginVerifyListMembership(string slug, string ownerScreenName, int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginVerifyListMembership(string slug, string ownerScreenName, int userId, bool skipStatus)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginVerifyListMembership(string slug, string ownerScreenName, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginVerifyListMembership(string slug, string ownerScreenName, string screenName, bool skipStatus)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginListListSubscriptions()
		{
			return BeginWithHammock<IEnumerable<TwitterList>>(WebMethod.Get, "lists/all", FormatAsString);
		}

		public virtual IAsyncResult BeginListListSubscriptionsFor(int userId)
		{
			return BeginWithHammock<IEnumerable<TwitterList>>(WebMethod.Get, "lists/all", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginListListSubscriptionsFor(string screenName)
		{
			return BeginWithHammock<IEnumerable<TwitterList>>(WebMethod.Get, "lists/all", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginListListSubscribers(long listId)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/subscribers", FormatAsString, "?list_id=", listId);
		}

		public virtual IAsyncResult BeginListListSubscribers(long listId, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/subscribers", FormatAsString, "?list_id=", listId, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListListSubscribers(long listId, bool skipStatus)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/subscribers", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginListListSubscribers(long listId, bool skipStatus, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/subscribers", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListListSubscribers(string slug, int ownerId)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/subscribers", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual IAsyncResult BeginListListSubscribers(string slug, int ownerId, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/subscribers", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListListSubscribers(string slug, string ownerScreenName, bool skipStatus)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/subscribers", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginListListSubscribers(string slug, string ownerScreenName, bool skipStatus, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/subscribers", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginFollowList(long listId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/create", FormatAsString, "?list_id=", listId);
		}

		public virtual IAsyncResult BeginFollowList(string slug, int ownerId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual IAsyncResult BeginFollowList(string slug, string ownerScreenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual IAsyncResult BeginUnfollowList(long listId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/destroy", FormatAsString, "?list_id=", listId);
		}

		public virtual IAsyncResult BeginUnfollowList(string slug, int ownerId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual IAsyncResult BeginUnfollowList(string slug, string ownerScreenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual IAsyncResult BeginVerifyListSubscription(long listId, int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/subscribers/show", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginVerifyListSubscription(long listId, int userId, bool skipStatus)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/subscribers/show", FormatAsString, "?list_id=", listId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginVerifyListSubscription(long listId, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/subscribers/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginVerifyListSubscription(long listId, string screenName, bool skipStatus)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/subscribers/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginVerifyListSubscription(string slug, int ownerId, int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginVerifyListSubscription(string slug, int ownerId, int userId, bool skipStatus)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginVerifyListSubscription(string slug, int ownerId, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginVerifyListSubscription(string slug, int ownerId, string screenName, bool skipStatus)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginVerifyListSubscription(string slug, string ownerScreenName, int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginVerifyListSubscription(string slug, string ownerScreenName, int userId, bool skipStatus)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginVerifyListSubscription(string slug, string ownerScreenName, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginVerifyListSubscription(string slug, string ownerScreenName, string screenName, bool skipStatus)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual IAsyncResult BeginFollowUserNotifications(string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "users/notifications/follow", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginFollowUserNotifications(int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "users/notifications/follow", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginUnfollowUserNotifications(int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "users/notifications/leave", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginUnfollowUserNotifications(string userScreenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "users/notifications/leave", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult BeginListSavedSearches()
		{
			return BeginWithHammock<IEnumerable<TwitterSavedSearch>>(WebMethod.Get, "saved_searches", FormatAsString);
		}

		public virtual IAsyncResult BeginGetSavedSearch(long id)
		{
			return BeginWithHammock<TwitterSavedSearch>(WebMethod.Get, "saved_searches/show", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginCreateSavedSearch(string query)
		{
			return BeginWithHammock<TwitterSavedSearch>(WebMethod.Post, "saved_searches/create", FormatAsString, "?query=", query);
		}

		public virtual IAsyncResult BeginDeleteSavedSearch(long id)
		{
			return BeginWithHammock<TwitterSavedSearch>(WebMethod.Delete, "saved_searches/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginSearch(string q)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?q=", q);
		}

		public virtual IAsyncResult BeginSearch(string q, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?q=", q, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearch(string q, int rpp)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?q=", q, "&rpp=", rpp);
		}

		public virtual IAsyncResult BeginSearch(string q, int rpp, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearch(string q, int page, int rpp)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual IAsyncResult BeginSearch(string q, int page, int rpp, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearchSince(long since_id, string q)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?since_id=", since_id, "&q=", q);
		}

		public virtual IAsyncResult BeginSearchSince(long since_id, string q, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearchSince(long since_id, string q, int rpp)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual IAsyncResult BeginSearchSince(long since_id, string q, int rpp, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearchSince(long since_id, string q, int page, int rpp)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual IAsyncResult BeginSearchSince(long since_id, string q, int page, int rpp, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearchBefore(long max_id, string q)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?max_id=", max_id, "&q=", q);
		}

		public virtual IAsyncResult BeginSearchBefore(long max_id, string q, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearchBefore(long max_id, string q, int rpp)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual IAsyncResult BeginSearchBefore(long max_id, string q, int rpp, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearchBefore(long max_id, string q, int page, int rpp)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual IAsyncResult BeginSearchBefore(long max_id, string q, int page, int rpp, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginReportSpam(int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "report_spam", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginReportSpam(string userScreenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "report_spam", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimeline()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimeline(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimeline(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineSince(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineBefore(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimeline(bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimeline(int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimeline(int page, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineSince(long sinceId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineSince(long sinceId, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineSince(long sinceId, int page, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineBefore(long maxId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineBefore(long maxId, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineBefore(long maxId, int page, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimeline()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimeline(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimeline(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineSince(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineBefore(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimeline(bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimeline(int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimeline(int page, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineSince(long sinceId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineSince(long sinceId, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineSince(long sinceId, int page, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineBefore(long maxId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineBefore(long maxId, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineBefore(long maxId, int page, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(int userId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(int userId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(int userId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(string screenName)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(string screenName, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(int userId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(int userId, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(int userId, int page, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(string screenName, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(string screenName, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count, bool includeRts)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMe()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMe(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMe(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMeSince(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMeSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMeSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMeBefore(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMeBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMeBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsByMe()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString);
		}

		public virtual IAsyncResult BeginListRetweetsByMe(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsByMe(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsByMe(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListRetweetsByMeSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsByMeSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsByMeBefore(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListRetweetsByMeBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsByMeBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsToMe()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString);
		}

		public virtual IAsyncResult BeginListRetweetsToMe(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsToMe(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsToMeSince(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListRetweetsToMeSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsToMeSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsToMeBefore(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListRetweetsToMeBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsToMeBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweets()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweets(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweets(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweets(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweetsSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweetsSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweetsSince(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweetsBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweetsBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListCurrentTrends(int woeid)
		{
			return BeginWithHammock<TwitterCurrentTrends>(WebMethod.Get, "trends/{woeid}", FormatAsString, "?woeid=", woeid);
		}

		public virtual IAsyncResult BeginListCurrentTrends(string exclude, int woeid)
		{
			return BeginWithHammock<TwitterCurrentTrends>(WebMethod.Get, "trends/{woeid}", FormatAsString, "?exclude=", exclude, "&woeid=", woeid);
		}

		public virtual IAsyncResult BeginListDailyTrends()
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/daily", FormatAsString);
		}

		public virtual IAsyncResult BeginListDailyTrends(DateTime date)
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/daily", FormatAsString, "?date=", date);
		}

		public virtual IAsyncResult BeginListDailyTrends(string exclude)
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/daily", FormatAsString, "?exclude=", exclude);
		}

		public virtual IAsyncResult BeginListDailyTrends(DateTime date, string exclude)
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/daily", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual IAsyncResult BeginListWeeklyTrends()
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/weekly", FormatAsString);
		}

		public virtual IAsyncResult BeginListWeeklyTrends(DateTime date)
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/weekly", FormatAsString, "?date=", date);
		}

		public virtual IAsyncResult BeginListWeeklyTrends(string exclude)
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/weekly", FormatAsString, "?exclude=", exclude);
		}

		public virtual IAsyncResult BeginListWeeklyTrends(DateTime date, string exclude)
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/weekly", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual IAsyncResult BeginListAvailableTrendsLocations()
		{
			return BeginWithHammock<IEnumerable<WhereOnEarthLocation>>(WebMethod.Get, "trends/available", FormatAsString);
		}

		public virtual IAsyncResult BeginListAvailableTrendsLocations(string lat)
		{
			return BeginWithHammock<IEnumerable<WhereOnEarthLocation>>(WebMethod.Get, "trends/available", FormatAsString, "?lat=", lat);
		}

		public virtual IAsyncResult BeginListAvailableTrendsLocations(string lat, string @long)
		{
			return BeginWithHammock<IEnumerable<WhereOnEarthLocation>>(WebMethod.Get, "trends/available", FormatAsString, "?lat=", lat, "&long=", @long);
		}

		public virtual IAsyncResult BeginListLocalTrendsFor(long woeId)
		{
			return BeginWithHammock<TwitterLocalTrends>(WebMethod.Get, "trends/{woe_id}", FormatAsString, "?woe_id=", woeId);
		}

		public virtual IAsyncResult BeginGetTweet(long id)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Get, "statuses/show/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginSendTweet(string status)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status);
		}

		public virtual IAsyncResult BeginSendTweet(string status, string lat, string @long)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&lat=", lat, "&long=", @long);
		}

		public virtual IAsyncResult BeginSendTweet(string status, long inReplyToStatusId)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId);
		}

		public virtual IAsyncResult BeginSendTweet(string status, long inReplyToStatusId, string lat, string @long)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId, "&lat=", lat, "&long=", @long);
		}

		public virtual IAsyncResult BeginDeleteTweet(long id)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Delete, "statuses/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginRetweet(long id)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Post, "statuses/retweet/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginRetweets(long id)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginRetweets(long id, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets/{id}", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IAsyncResult BeginListUsersWhoRetweeted(long id)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "statuses/{id}/retweeted_by", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginListUsersWhoRetweeted(long id, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "statuses/{id}/retweeted_by", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IAsyncResult BeginListUserIdsWhoRetweeted(long id)
		{
			return BeginWithHammock<IEnumerable<int>>(WebMethod.Get, "statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginListUserIdsWhoRetweeted(long id, int count)
		{
			return BeginWithHammock<IEnumerable<int>>(WebMethod.Get, "statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IAsyncResult BeginGetUserProfile()
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "account/verify_credentials", FormatAsString);
		}

		public virtual IAsyncResult BeginGetUserProfileFor(string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "users/show", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginGetUserProfileFor(int id)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "users/show", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginSearchForUser(string q)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "users/search", FormatAsString, "?q=", q);
		}

		public virtual IAsyncResult BeginSearchForUser(string q, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "users/search", FormatAsString, "?q=", q, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginSearchForUser(string q, int page, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "users/search", FormatAsString, "?q=", q, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListUserProfilesFor(string userId)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "users/lookup", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginGetProfileImageFor(string screenName)
		{
			return BeginWithHammock<byte[]>(WebMethod.Get, "users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginGetProfileImageFor(string screenName, TwitterProfileImageSize size)
		{
			return BeginWithHammock<byte[]>(WebMethod.Get, "users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName, "&size=", size);
		}

		public virtual IAsyncResult BeginListSuggestedUserCategories()
		{
			return BeginWithHammock<IEnumerable<TwitterUserSuggestions>>(WebMethod.Get, "users/suggestions", FormatAsString);
		}

		public virtual IAsyncResult BeginListSuggestedUsers(string categorySlug)
		{
			return BeginWithHammock<TwitterUserSuggestions>(WebMethod.Get, "/users/suggestions/{category_slug}", FormatAsString, "?category_slug=", categorySlug);
		}

		public virtual TwitterUser EndVerifyCredentials(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndVerifyCredentials(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterRateLimitStatus EndGetRateLimitStatus(IAsyncResult result) 
		{
			return EndWithHammock<TwitterRateLimitStatus>(result);
		}

		public virtual TwitterRateLimitStatus EndGetRateLimitStatus(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterRateLimitStatus>(result, timeout);
		}

		public virtual TwitterError EndEndSession(IAsyncResult result) 
		{
			return EndWithHammock<TwitterError>(result);
		}

		public virtual TwitterError EndEndSession(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterError>(result, timeout);
		}

		public virtual TwitterUser EndUpdateDeliveryDevice(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUpdateDeliveryDevice(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUpdateProfileColors(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUpdateProfileColors(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUpdateProfileImage(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUpdateProfileImage(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUpdateProfileBackgroundImage(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUpdateProfileBackgroundImage(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUpdateProfile(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUpdateProfile(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterConfiguration EndGetConfiguration(IAsyncResult result) 
		{
			return EndWithHammock<TwitterConfiguration>(result);
		}

		public virtual TwitterConfiguration EndGetConfiguration(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterConfiguration>(result, timeout);
		}

		public virtual TwitterUser EndBlockUser(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndBlockUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUnblockUser(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUnblockUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndVerifyBlocking(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndVerifyBlocking(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual IEnumerable<TwitterUser> EndListBlockedUsers(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result);
		}

		public virtual IEnumerable<TwitterUser> EndListBlockedUsers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result, timeout);
		}

		public virtual IEnumerable<int> EndListBlockedUserIds(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<int>>(result);
		}

		public virtual IEnumerable<int> EndListBlockedUserIds(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<int>>(result, timeout);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceived(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceived(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result, timeout);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result, timeout);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result, timeout);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesSent(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesSent(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result, timeout);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result, timeout);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result, timeout);
		}

		public virtual TwitterDirectMessage EndDeleteDirectMessage(IAsyncResult result) 
		{
			return EndWithHammock<TwitterDirectMessage>(result);
		}

		public virtual TwitterDirectMessage EndDeleteDirectMessage(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterDirectMessage>(result, timeout);
		}

		public virtual TwitterDirectMessage EndSendDirectMessage(IAsyncResult result) 
		{
			return EndWithHammock<TwitterDirectMessage>(result);
		}

		public virtual TwitterDirectMessage EndSendDirectMessage(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterDirectMessage>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListFavoriteTweets(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListFavoriteTweets(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListFavoriteTweetsFor(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListFavoriteTweetsFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual TwitterStatus EndFavoriteTweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		public virtual TwitterStatus EndFavoriteTweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

		public virtual TwitterStatus EndUnfavoriteTweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		public virtual TwitterStatus EndUnfavoriteTweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

		public virtual TwitterCursorList<int> EndListFriendIdsOf(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result);
		}

		public virtual TwitterCursorList<int> EndListFriendIdsOf(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result, timeout);
		}

		public virtual TwitterCursorList<int> EndListFollowerIdsOf(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result);
		}

		public virtual TwitterCursorList<int> EndListFollowerIdsOf(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result, timeout);
		}

		public virtual TwitterUser EndFollowUser(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndFollowUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUnfollowUser(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUnfollowUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterCursorList<int> EndGetIncomingFriendRequests(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result);
		}

		public virtual TwitterCursorList<int> EndGetIncomingFriendRequests(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result, timeout);
		}

		public virtual TwitterCursorList<int> EndGetOutgoingFriendRequests(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result);
		}

		public virtual TwitterCursorList<int> EndGetOutgoingFriendRequests(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result, timeout);
		}

		public virtual TwitterFriendship EndGetFriendshipInfo(IAsyncResult result) 
		{
			return EndWithHammock<TwitterFriendship>(result);
		}

		public virtual TwitterFriendship EndGetFriendshipInfo(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterFriendship>(result, timeout);
		}

		public virtual TwitterList EndCreateList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterList>(result);
		}

		public virtual TwitterList EndCreateList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterList>(result, timeout);
		}

		public virtual TwitterList EndUpdateList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterList>(result);
		}

		public virtual TwitterList EndUpdateList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterList>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterList> EndListLists(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result);
		}

		public virtual TwitterCursorList<TwitterList> EndListLists(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterList> EndListListsFor(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result);
		}

		public virtual TwitterCursorList<TwitterList> EndListListsFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result, timeout);
		}

		public virtual TwitterList EndGetList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterList>(result);
		}

		public virtual TwitterList EndGetList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterList>(result, timeout);
		}

		public virtual TwitterList EndDeleteList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterList>(result);
		}

		public virtual TwitterList EndDeleteList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterList>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnList(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnListSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnListSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnListBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnListBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterList> EndListListMemberships(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result);
		}

		public virtual TwitterCursorList<TwitterList> EndListListMemberships(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterList> EndListListMembershipsFor(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result);
		}

		public virtual TwitterCursorList<TwitterList> EndListListMembershipsFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterUser> EndListListMembers(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result);
		}

		public virtual TwitterCursorList<TwitterUser> EndListListMembers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result, timeout);
		}

		public virtual TwitterUser EndAddListMember(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndAddListMember(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndRemoveListMember(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndRemoveListMember(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterList> EndAddListMembers(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result);
		}

		public virtual TwitterCursorList<TwitterList> EndAddListMembers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterList> EndAddListMembersByScreenName(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result);
		}

		public virtual TwitterCursorList<TwitterList> EndAddListMembersByScreenName(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result, timeout);
		}

		public virtual TwitterUser EndVerifyListMembership(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndVerifyListMembership(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual IEnumerable<TwitterList> EndListListSubscriptions(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterList>>(result);
		}

		public virtual IEnumerable<TwitterList> EndListListSubscriptions(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterList>>(result, timeout);
		}

		public virtual IEnumerable<TwitterList> EndListListSubscriptionsFor(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterList>>(result);
		}

		public virtual IEnumerable<TwitterList> EndListListSubscriptionsFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterList>>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterUser> EndListListSubscribers(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result);
		}

		public virtual TwitterCursorList<TwitterUser> EndListListSubscribers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result, timeout);
		}

		public virtual TwitterUser EndFollowList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndFollowList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUnfollowList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUnfollowList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndVerifyListSubscription(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndVerifyListSubscription(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndFollowUserNotifications(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndFollowUserNotifications(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUnfollowUserNotifications(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUnfollowUserNotifications(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual IEnumerable<TwitterSavedSearch> EndListSavedSearches(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterSavedSearch>>(result);
		}

		public virtual IEnumerable<TwitterSavedSearch> EndListSavedSearches(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterSavedSearch>>(result, timeout);
		}

		public virtual TwitterSavedSearch EndGetSavedSearch(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSavedSearch>(result);
		}

		public virtual TwitterSavedSearch EndGetSavedSearch(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSavedSearch>(result, timeout);
		}

		public virtual TwitterSavedSearch EndCreateSavedSearch(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSavedSearch>(result);
		}

		public virtual TwitterSavedSearch EndCreateSavedSearch(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSavedSearch>(result, timeout);
		}

		public virtual TwitterSavedSearch EndDeleteSavedSearch(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSavedSearch>(result);
		}

		public virtual TwitterSavedSearch EndDeleteSavedSearch(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSavedSearch>(result, timeout);
		}

		public virtual TwitterSearchResult EndSearch(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSearchResult>(result);
		}

		public virtual TwitterSearchResult EndSearch(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSearchResult>(result, timeout);
		}

		public virtual TwitterSearchResult EndSearchSince(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSearchResult>(result);
		}

		public virtual TwitterSearchResult EndSearchSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSearchResult>(result, timeout);
		}

		public virtual TwitterSearchResult EndSearchBefore(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSearchResult>(result);
		}

		public virtual TwitterSearchResult EndSearchBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSearchResult>(result, timeout);
		}

		public virtual TwitterUser EndReportSpam(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndReportSpam(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnHomeTimeline(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnHomeTimeline(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnUserTimeline(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnUserTimeline(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimeline(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimeline(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsMentioningMe(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsMentioningMe(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsMentioningMeSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsMentioningMeSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsMentioningMeBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsMentioningMeBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsByMe(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsByMe(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsByMeSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsByMeSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsByMeBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsByMeBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsToMe(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsToMe(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsToMeSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsToMeSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsToMeBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsToMeBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsOfMyTweets(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsOfMyTweets(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual TwitterCurrentTrends EndListCurrentTrends(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCurrentTrends>(result);
		}

		public virtual TwitterCurrentTrends EndListCurrentTrends(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCurrentTrends>(result, timeout);
		}

		public virtual TwitterTrends EndListDailyTrends(IAsyncResult result) 
		{
			return EndWithHammock<TwitterTrends>(result);
		}

		public virtual TwitterTrends EndListDailyTrends(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterTrends>(result, timeout);
		}

		public virtual TwitterTrends EndListWeeklyTrends(IAsyncResult result) 
		{
			return EndWithHammock<TwitterTrends>(result);
		}

		public virtual TwitterTrends EndListWeeklyTrends(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterTrends>(result, timeout);
		}

		public virtual IEnumerable<WhereOnEarthLocation> EndListAvailableTrendsLocations(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<WhereOnEarthLocation>>(result);
		}

		public virtual IEnumerable<WhereOnEarthLocation> EndListAvailableTrendsLocations(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<WhereOnEarthLocation>>(result, timeout);
		}

		public virtual TwitterLocalTrends EndListLocalTrendsFor(IAsyncResult result) 
		{
			return EndWithHammock<TwitterLocalTrends>(result);
		}

		public virtual TwitterLocalTrends EndListLocalTrendsFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterLocalTrends>(result, timeout);
		}

		public virtual TwitterStatus EndGetTweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		public virtual TwitterStatus EndGetTweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

		public virtual TwitterStatus EndSendTweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		public virtual TwitterStatus EndSendTweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

		public virtual TwitterStatus EndDeleteTweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		public virtual TwitterStatus EndDeleteTweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

		public virtual TwitterStatus EndRetweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		public virtual TwitterStatus EndRetweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndRetweets(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndRetweets(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterUser> EndListUsersWhoRetweeted(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result);
		}

		public virtual IEnumerable<TwitterUser> EndListUsersWhoRetweeted(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result, timeout);
		}

		public virtual IEnumerable<int> EndListUserIdsWhoRetweeted(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<int>>(result);
		}

		public virtual IEnumerable<int> EndListUserIdsWhoRetweeted(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<int>>(result, timeout);
		}

		public virtual TwitterUser EndGetUserProfile(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndGetUserProfile(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndGetUserProfileFor(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndGetUserProfileFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual IEnumerable<TwitterUser> EndSearchForUser(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result);
		}

		public virtual IEnumerable<TwitterUser> EndSearchForUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result, timeout);
		}

		public virtual IEnumerable<TwitterUser> EndListUserProfilesFor(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result);
		}

		public virtual IEnumerable<TwitterUser> EndListUserProfilesFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result, timeout);
		}

		public virtual byte[] EndGetProfileImageFor(IAsyncResult result) 
		{
			return EndWithHammock<byte[]>(result);
		}

		public virtual byte[] EndGetProfileImageFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<byte[]>(result, timeout);
		}

		public virtual IEnumerable<TwitterUserSuggestions> EndListSuggestedUserCategories(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterUserSuggestions>>(result);
		}

		public virtual IEnumerable<TwitterUserSuggestions> EndListSuggestedUserCategories(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterUserSuggestions>>(result, timeout);
		}

		public virtual TwitterUserSuggestions EndListSuggestedUsers(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUserSuggestions>(result);
		}

		public virtual TwitterUserSuggestions EndListSuggestedUsers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUserSuggestions>(result, timeout);
		}

		#endregion
#endif

#if WINDOWS_PHONE
		#region Asynchronous Methods (without IAsyncResult)
		public virtual void VerifyCredentials(Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "account/verify_credentials", FormatAsString);
		}

		public virtual void GetRateLimitStatus(Action<TwitterRateLimitStatus, TwitterResponse> action)
		{
			WithHammock(action, "account/rate_limit_status", FormatAsString);
		}

		public virtual void EndSession(Action<TwitterError, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/end_session", FormatAsString);
		}

		public virtual void UpdateDeliveryDevice(TwitterDeliveryDevice device, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "account/update_delivery_device", FormatAsString, "?device=", device);
		}

		public virtual void UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, string sidebarBorderColor, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor, "&sidebar_border_color=", sidebarBorderColor);
		}

		public virtual void UpdateProfileColors(string backgroundColor, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor);
		}

		public virtual void UpdateProfileColors(string backgroundColor, string textColor, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor);
		}

		public virtual void UpdateProfileColors(string backgroundColor, string textColor, string linkColor, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor);
		}

		public virtual void UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor);
		}

		public virtual void UpdateProfileImage(string path, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile_image", FormatAsString, "?path=", path);
		}

		public virtual void UpdateProfileBackgroundImage(string path, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile_background_image", FormatAsString, "?path=", path);
		}

		public virtual void UpdateProfile(string name, string description, string email, string url, string location, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile", FormatAsString, "?name=", name, "&description=", description, "&email=", email, "&url=", url, "&location=", location);
		}

		public virtual void GetConfiguration(Action<TwitterConfiguration, TwitterResponse> action)
		{
			WithHammock(action, "help/configuration", FormatAsString);
		}

		public virtual void BlockUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "blocks/create", FormatAsString, "?user_id=", userId);
		}

		public virtual void BlockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "blocks/create", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual void UnblockUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "blocks/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual void UnblockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "blocks/destroy", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual void VerifyBlocking(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "blocks/exists", FormatAsString, "?user_id=", userId);
		}

		public virtual void VerifyBlocking(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "blocks/exists", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual void ListBlockedUsers(Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "blocks/blocking", FormatAsString);
		}

		public virtual void ListBlockedUsers(int page, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "blocks/blocking", FormatAsString, "?page=", page);
		}

		public virtual void ListBlockedUserIds(Action<IEnumerable<int>, TwitterResponse> action)
		{
			WithHammock(action, "blocks/blocking/ids", FormatAsString);
		}

		public virtual void ListDirectMessagesReceived(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString);
		}

		public virtual void ListDirectMessagesReceived(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?count=", count);
		}

		public virtual void ListDirectMessagesReceived(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListDirectMessagesReceivedSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListDirectMessagesReceivedSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListDirectMessagesReceivedSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListDirectMessagesReceivedBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListDirectMessagesReceivedBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListDirectMessagesReceivedBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListDirectMessagesSent(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString);
		}

		public virtual void ListDirectMessagesSent(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?count=", count);
		}

		public virtual void ListDirectMessagesSent(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListDirectMessagesSentSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListDirectMessagesSentSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListDirectMessagesSentSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListDirectMessagesSentBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListDirectMessagesSentBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListDirectMessagesSentBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void DeleteDirectMessage(long id, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual void DeleteDirectMessage(int id, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual void SendDirectMessage(int userId, string text, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "direct_messages/new", FormatAsString, "?user_id=", userId, "&text=", text);
		}

		public virtual void SendDirectMessage(string screenName, string text, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "direct_messages/new", FormatAsString, "?screen_name=", screenName, "&text=", text);
		}

		public virtual void ListFavoriteTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites", FormatAsString);
		}

		public virtual void ListFavoriteTweets(int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites", FormatAsString, "?page=", page);
		}

		public virtual void ListFavoriteTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListFavoriteTweetsFor(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId);
		}

		public virtual void ListFavoriteTweetsFor(int userId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page);
		}

		public virtual void ListFavoriteTweetsFor(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual void ListFavoriteTweetsFor(string userScreenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual void ListFavoriteTweetsFor(string userScreenName, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page);
		}

		public virtual void ListFavoriteTweetsFor(string userScreenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page, "&count=", count);
		}

		public virtual void FavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "favorites/create/{id}", FormatAsString, "?id=", id);
		}

		public virtual void UnfavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "favorites/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual void ListFriendIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "friends/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual void ListFriendIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "friends/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual void ListFollowerIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "followers/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual void ListFollowerIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "followers/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual void FollowUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "friendships/create", FormatAsString, "?user_id=", userId);
		}

		public virtual void FollowUser(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "friendships/create", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void UnfollowUser(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "friendships/destroy", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void UnfollowUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "friendships/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual void GetIncomingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "friendships/incoming", FormatAsString);
		}

		public virtual void GetIncomingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "friendships/incoming", FormatAsString, "?cursor=", cursor);
		}

		public virtual void GetOutgoingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "friendships/outgoing", FormatAsString);
		}

		public virtual void GetOutgoingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "friendships/outgoing", FormatAsString, "?cursor=", cursor);
		}

		public virtual void GetFriendshipInfo(string sourceScreenName, string targetScreenName, Action<TwitterFriendship, TwitterResponse> action)
		{
			WithHammock(action, "friendships/show", FormatAsString, "?source_screen_name=", sourceScreenName, "&target_screen_name=", targetScreenName);
		}

		public virtual void GetFriendshipInfo(int sourceId, int targetId, Action<TwitterFriendship, TwitterResponse> action)
		{
			WithHammock(action, "friendships/show", FormatAsString, "?source_id=", sourceId, "&target_id=", targetId);
		}

		public virtual void CreateList(string name, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/create", FormatAsString, "?name=", name);
		}

		public virtual void CreateList(string name, string description, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/create", FormatAsString, "?name=", name, "&description=", description);
		}

		public virtual void CreateList(string name, string description, string mode, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/create", FormatAsString, "?name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual void UpdateList(long listId, string name, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?list_id=", listId, "&name=", name);
		}

		public virtual void UpdateList(long listId, string name, string description, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?list_id=", listId, "&name=", name, "&description=", description);
		}

		public virtual void UpdateList(long listId, string name, string description, string mode, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?list_id=", listId, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual void UpdateList(string slug, int ownerId, string name, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&name=", name);
		}

		public virtual void UpdateList(string slug, int ownerId, string name, string description, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&name=", name, "&description=", description);
		}

		public virtual void UpdateList(string slug, int ownerId, string name, string description, string mode, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual void UpdateList(string slug, string ownerScreenName, string name, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&name=", name);
		}

		public virtual void UpdateList(string slug, string ownerScreenName, string name, string description, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&name=", name, "&description=", description);
		}

		public virtual void UpdateList(string slug, string ownerScreenName, string name, string description, string mode, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/update", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual void ListLists(Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists", FormatAsString);
		}

		public virtual void ListLists(long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists", FormatAsString, "?cursor=", cursor);
		}

		public virtual void ListListsFor(int userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists", FormatAsString, "?user_id=", userId);
		}

		public virtual void ListListsFor(int userId, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual void ListListsFor(string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void ListListsFor(string screenName, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual void GetList(int userId, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(action, "lists/show", FormatAsString, "?user_id=", userId);
		}

		public virtual void GetList(string slug, int ownerId, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(action, "lists/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual void GetList(string slug, string ownerScreenName, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(action, "lists/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual void DeleteList(long listId, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/destroy", FormatAsString, "?list_id=", listId);
		}

		public virtual void DeleteList(string slug, int ownerId, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/destroy", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual void DeleteList(string slug, string ownerScreenName, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/destroy", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual void ListTweetsOnList(long listId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId);
		}

		public virtual void ListTweetsOnList(long listId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnList(long listId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnList(long listId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnList(long listId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnList(long listId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnList(string slug, int ownerId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual void ListTweetsOnList(string slug, int ownerId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnList(string slug, int ownerId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnList(string slug, int ownerId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnList(string slug, int ownerId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&page=", page, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnList(string slug, int ownerId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnList(string slug, string ownerScreenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual void ListTweetsOnList(string slug, string ownerScreenName, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnList(string slug, string ownerScreenName, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnList(string slug, string ownerScreenName, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnList(string slug, string ownerScreenName, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&page=", page, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnList(string slug, string ownerScreenName, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListSince(long listId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId);
		}

		public virtual void ListTweetsOnListSince(long listId, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListSince(long listId, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListSince(long listId, long sinceId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListSince(long listId, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListSince(long listId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListSince(string slug, int ownerId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId);
		}

		public virtual void ListTweetsOnListSince(string slug, int ownerId, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListSince(string slug, int ownerId, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListSince(string slug, int ownerId, long sinceId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListSince(string slug, int ownerId, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListSince(string slug, int ownerId, long sinceId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId);
		}

		public virtual void ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListSince(string slug, string ownerScreenName, long sinceId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListBefore(long listId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId);
		}

		public virtual void ListTweetsOnListBefore(long listId, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListBefore(long listId, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListBefore(long listId, long maxId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListBefore(long listId, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListBefore(long listId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?list_id=", listId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListBefore(string slug, int ownerId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId);
		}

		public virtual void ListTweetsOnListBefore(string slug, int ownerId, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListBefore(string slug, int ownerId, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListBefore(string slug, int ownerId, long maxId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListBefore(string slug, int ownerId, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListBefore(string slug, int ownerId, long maxId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&max_id=", maxId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId);
		}

		public virtual void ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListBefore(string slug, string ownerScreenName, long maxId, int page, int perPage, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&max_id=", maxId, "&page=", page, "&per_page=", perPage, "&include_rts=", includeRts);
		}

		public virtual void ListListMemberships(Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists/memberships", FormatAsString);
		}

		public virtual void ListListMembershipsFor(int userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists/memberships", FormatAsString, "?user_id=", userId);
		}

		public virtual void ListListMembershipsFor(int userId, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists/memberships", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual void ListListMembershipsFor(int userId, bool filterToOwnedLists, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists/memberships", FormatAsString, "?user_id=", userId, "&filter_to_owned_lists=", filterToOwnedLists);
		}

		public virtual void ListListMembershipsFor(int userId, bool filterToOwnedLists, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists/memberships", FormatAsString, "?user_id=", userId, "&filter_to_owned_lists=", filterToOwnedLists, "&cursor=", cursor);
		}

		public virtual void ListListMembershipsFor(string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists/memberships", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void ListListMembershipsFor(string screenName, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists/memberships", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual void ListListMembershipsFor(string screenName, bool filterToOwnedLists, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists/memberships", FormatAsString, "?screen_name=", screenName, "&filter_to_owned_lists=", filterToOwnedLists);
		}

		public virtual void ListListMembershipsFor(string screenName, bool filterToOwnedLists, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists/memberships", FormatAsString, "?screen_name=", screenName, "&filter_to_owned_lists=", filterToOwnedLists, "&cursor=", cursor);
		}

		public virtual void ListListMembers(long listId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/members", FormatAsString, "?list_id=", listId);
		}

		public virtual void ListListMembers(long listId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/members", FormatAsString, "?list_id=", listId, "&cursor=", cursor);
		}

		public virtual void ListListMembers(long listId, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/members", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus);
		}

		public virtual void ListListMembers(long listId, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/members", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual void ListListMembers(string slug, int ownerId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/members", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual void ListListMembers(string slug, int ownerId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/members", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&cursor=", cursor);
		}

		public virtual void ListListMembers(string slug, string ownerScreenName, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/members", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus);
		}

		public virtual void ListListMembers(string slug, string ownerScreenName, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/members", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual void AddListMember(long listId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/create", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual void AddListMember(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual void AddListMember(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual void AddListMember(long listId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/create", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual void AddListMember(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual void AddListMember(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual void RemoveListMember(long listId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual void RemoveListMember(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual void RemoveListMember(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual void RemoveListMember(long listId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual void RemoveListMember(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual void RemoveListMember(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual void AddListMembers(long listId, string userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/create_all", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual void AddListMembersByScreenName(long listId, string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/create_all", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual void AddListMembers(string slug, int ownerId, string userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual void AddListMembersByScreenName(string slug, int ownerId, string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual void AddListMembers(string slug, string ownerScreenName, string userId, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual void AddListMembersByScreenName(string slug, string ownerScreenName, string screenName, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/create_all", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual void VerifyListMembership(long listId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/members/show", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual void VerifyListMembership(long listId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/members/show", FormatAsString, "?list_id=", listId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual void VerifyListMembership(long listId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/members/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual void VerifyListMembership(long listId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/members/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual void VerifyListMembership(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual void VerifyListMembership(string slug, int ownerId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual void VerifyListMembership(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual void VerifyListMembership(string slug, int ownerId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual void VerifyListMembership(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual void VerifyListMembership(string slug, string ownerScreenName, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual void VerifyListMembership(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual void VerifyListMembership(string slug, string ownerScreenName, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/members/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual void ListListSubscriptions(Action<IEnumerable<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists/all", FormatAsString);
		}

		public virtual void ListListSubscriptionsFor(int userId, Action<IEnumerable<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists/all", FormatAsString, "?user_id=", userId);
		}

		public virtual void ListListSubscriptionsFor(string screenName, Action<IEnumerable<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists/all", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void ListListSubscribers(long listId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers", FormatAsString, "?list_id=", listId);
		}

		public virtual void ListListSubscribers(long listId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers", FormatAsString, "?list_id=", listId, "&cursor=", cursor);
		}

		public virtual void ListListSubscribers(long listId, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus);
		}

		public virtual void ListListSubscribers(long listId, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers", FormatAsString, "?list_id=", listId, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual void ListListSubscribers(string slug, int ownerId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual void ListListSubscribers(string slug, int ownerId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&cursor=", cursor);
		}

		public virtual void ListListSubscribers(string slug, string ownerScreenName, bool skipStatus, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus);
		}

		public virtual void ListListSubscribers(string slug, string ownerScreenName, bool skipStatus, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&skip_status=", skipStatus, "&cursor=", cursor);
		}

		public virtual void FollowList(long listId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/subscribers/create", FormatAsString, "?list_id=", listId);
		}

		public virtual void FollowList(string slug, int ownerId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual void FollowList(string slug, string ownerScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual void UnfollowList(long listId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/subscribers/destroy", FormatAsString, "?list_id=", listId);
		}

		public virtual void UnfollowList(string slug, int ownerId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_id=", ownerId);
		}

		public virtual void UnfollowList(string slug, string ownerScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/subscribers/create", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName);
		}

		public virtual void VerifyListSubscription(long listId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers/show", FormatAsString, "?list_id=", listId, "&user_id=", userId);
		}

		public virtual void VerifyListSubscription(long listId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers/show", FormatAsString, "?list_id=", listId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual void VerifyListSubscription(long listId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName);
		}

		public virtual void VerifyListSubscription(long listId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers/show", FormatAsString, "?list_id=", listId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual void VerifyListSubscription(string slug, int ownerId, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId);
		}

		public virtual void VerifyListSubscription(string slug, int ownerId, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual void VerifyListSubscription(string slug, int ownerId, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName);
		}

		public virtual void VerifyListSubscription(string slug, int ownerId, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_id=", ownerId, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual void VerifyListSubscription(string slug, string ownerScreenName, int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId);
		}

		public virtual void VerifyListSubscription(string slug, string ownerScreenName, int userId, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&user_id=", userId, "&skip_status=", skipStatus);
		}

		public virtual void VerifyListSubscription(string slug, string ownerScreenName, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName);
		}

		public virtual void VerifyListSubscription(string slug, string ownerScreenName, string screenName, bool skipStatus, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers/show", FormatAsString, "?slug=", slug, "&owner_screen_name=", ownerScreenName, "&screen_name=", screenName, "&skip_status=", skipStatus);
		}

		public virtual void FollowUserNotifications(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "users/notifications/follow", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void FollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "users/notifications/follow", FormatAsString, "?user_id=", userId);
		}

		public virtual void UnfollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "users/notifications/leave", FormatAsString, "?user_id=", userId);
		}

		public virtual void UnfollowUserNotifications(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "users/notifications/leave", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual void ListSavedSearches(Action<IEnumerable<TwitterSavedSearch>, TwitterResponse> action)
		{
			WithHammock(action, "saved_searches", FormatAsString);
		}

		public virtual void GetSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action)
		{
			WithHammock(action, "saved_searches/show", FormatAsString, "?id=", id);
		}

		public virtual void CreateSavedSearch(string query, Action<TwitterSavedSearch, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "saved_searches/create", FormatAsString, "?query=", query);
		}

		public virtual void DeleteSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "saved_searches/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual void Search(string q, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?q=", q);
		}

		public virtual void Search(string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?q=", q, "&result_type=", resultType);
		}

		public virtual void Search(string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?q=", q, "&rpp=", rpp);
		}

		public virtual void Search(string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual void Search(string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual void Search(string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual void SearchSince(long since_id, string q, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q);
		}

		public virtual void SearchSince(long since_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual void SearchSince(long since_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual void SearchSince(long since_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual void SearchSince(long since_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual void SearchSince(long since_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual void SearchBefore(long max_id, string q, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q);
		}

		public virtual void SearchBefore(long max_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual void SearchBefore(long max_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual void SearchBefore(long max_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual void SearchBefore(long max_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual void SearchBefore(long max_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual void ReportSpam(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "report_spam", FormatAsString, "?user_id=", userId);
		}

		public virtual void ReportSpam(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "report_spam", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual void ListTweetsOnHomeTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString);
		}

		public virtual void ListTweetsOnHomeTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?count=", count);
		}

		public virtual void ListTweetsOnHomeTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnHomeTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListTweetsOnHomeTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListTweetsOnHomeTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnHomeTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListTweetsOnHomeTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListTweetsOnHomeTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnHomeTimeline(bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?include_rts=", includeRts);
		}

		public virtual void ListTweetsOnHomeTimeline(int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnHomeTimeline(int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnHomeTimelineSince(long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnHomeTimelineSince(long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnHomeTimelineSince(long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnHomeTimelineBefore(long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnHomeTimelineBefore(long maxId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnHomeTimelineBefore(long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnUserTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString);
		}

		public virtual void ListTweetsOnUserTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?count=", count);
		}

		public virtual void ListTweetsOnUserTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnUserTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListTweetsOnUserTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListTweetsOnUserTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnUserTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListTweetsOnUserTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListTweetsOnUserTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnUserTimeline(bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?include_rts=", includeRts);
		}

		public virtual void ListTweetsOnUserTimeline(int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnUserTimeline(int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnUserTimelineSince(long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnUserTimelineSince(long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnUserTimelineSince(long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnUserTimelineBefore(long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnUserTimelineBefore(long maxId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnUserTimelineBefore(long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(int userId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(string screenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(string screenName, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(int userId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(int userId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(string screenName, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(string screenName, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count, bool includeRts, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&count=", count, "&include_rts=", includeRts);
		}

		public virtual void ListTweetsMentioningMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString);
		}

		public virtual void ListTweetsMentioningMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?count=", count);
		}

		public virtual void ListTweetsMentioningMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListTweetsMentioningMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListTweetsMentioningMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListTweetsMentioningMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsMentioningMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListTweetsMentioningMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListTweetsMentioningMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListRetweetsByMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString);
		}

		public virtual void ListRetweetsByMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?count=", count);
		}

		public virtual void ListRetweetsByMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListRetweetsByMe(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListRetweetsByMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListRetweetsByMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListRetweetsByMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListRetweetsByMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListRetweetsByMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListRetweetsToMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString);
		}

		public virtual void ListRetweetsToMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?count=", count);
		}

		public virtual void ListRetweetsToMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListRetweetsToMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListRetweetsToMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListRetweetsToMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListRetweetsToMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListRetweetsToMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListRetweetsToMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListRetweetsOfMyTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString);
		}

		public virtual void ListRetweetsOfMyTweets(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?count=", count);
		}

		public virtual void ListRetweetsOfMyTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListRetweetsOfMyTweets(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListRetweetsOfMyTweetsSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListRetweetsOfMyTweetsSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListRetweetsOfMyTweetsSince(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListRetweetsOfMyTweetsBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListRetweetsOfMyTweetsBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListCurrentTrends(int woeid, Action<TwitterCurrentTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/{woeid}", FormatAsString, "?woeid=", woeid);
		}

		public virtual void ListCurrentTrends(string exclude, int woeid, Action<TwitterCurrentTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/{woeid}", FormatAsString, "?exclude=", exclude, "&woeid=", woeid);
		}

		public virtual void ListDailyTrends(Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/daily", FormatAsString);
		}

		public virtual void ListDailyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/daily", FormatAsString, "?date=", date);
		}

		public virtual void ListDailyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/daily", FormatAsString, "?exclude=", exclude);
		}

		public virtual void ListDailyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/daily", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual void ListWeeklyTrends(Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/weekly", FormatAsString);
		}

		public virtual void ListWeeklyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/weekly", FormatAsString, "?date=", date);
		}

		public virtual void ListWeeklyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/weekly", FormatAsString, "?exclude=", exclude);
		}

		public virtual void ListWeeklyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/weekly", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual void ListAvailableTrendsLocations(Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action)
		{
			WithHammock(action, "trends/available", FormatAsString);
		}

		public virtual void ListAvailableTrendsLocations(string lat, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action)
		{
			WithHammock(action, "trends/available", FormatAsString, "?lat=", lat);
		}

		public virtual void ListAvailableTrendsLocations(string lat, string @long, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action)
		{
			WithHammock(action, "trends/available", FormatAsString, "?lat=", lat, "&long=", @long);
		}

		public virtual void ListLocalTrendsFor(long woeId, Action<TwitterLocalTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/{woe_id}", FormatAsString, "?woe_id=", woeId);
		}

		public virtual void GetTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(action, "statuses/show/{id}", FormatAsString, "?id=", id);
		}

		public virtual void SendTweet(string status, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status);
		}

		public virtual void SendTweet(string status, string lat, string @long, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status, "&lat=", lat, "&long=", @long);
		}

		public virtual void SendTweet(string status, long inReplyToStatusId, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId);
		}

		public virtual void SendTweet(string status, long inReplyToStatusId, string lat, string @long, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId, "&lat=", lat, "&long=", @long);
		}

		public virtual void DeleteTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "statuses/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual void Retweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "statuses/retweet/{id}", FormatAsString, "?id=", id);
		}

		public virtual void Retweets(long id, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets/{id}", FormatAsString, "?id=", id);
		}

		public virtual void Retweets(long id, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets/{id}", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual void ListUsersWhoRetweeted(long id, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/{id}/retweeted_by", FormatAsString, "?id=", id);
		}

		public virtual void ListUsersWhoRetweeted(long id, int count, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/{id}/retweeted_by", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual void ListUserIdsWhoRetweeted(long id, Action<IEnumerable<int>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id);
		}

		public virtual void ListUserIdsWhoRetweeted(long id, int count, Action<IEnumerable<int>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual void GetUserProfile(Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "account/verify_credentials", FormatAsString);
		}

		public virtual void GetUserProfileFor(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "users/show", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void GetUserProfileFor(int id, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "users/show", FormatAsString, "?id=", id);
		}

		public virtual void SearchForUser(string q, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "users/search", FormatAsString, "?q=", q);
		}

		public virtual void SearchForUser(string q, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "users/search", FormatAsString, "?q=", q, "&per_page=", perPage);
		}

		public virtual void SearchForUser(string q, int page, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "users/search", FormatAsString, "?q=", q, "&page=", page, "&per_page=", perPage);
		}

		public virtual void ListUserProfilesFor(string userId, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "users/lookup", FormatAsString, "?user_id=", userId);
		}

		public virtual void GetProfileImageFor(string screenName, Action<byte[], TwitterResponse> action)
		{
			WithHammock(action, "users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void GetProfileImageFor(string screenName, TwitterProfileImageSize size, Action<byte[], TwitterResponse> action)
		{
			WithHammock(action, "users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName, "&size=", size);
		}

		public virtual void ListSuggestedUserCategories(Action<IEnumerable<TwitterUserSuggestions>, TwitterResponse> action)
		{
			WithHammock(action, "users/suggestions", FormatAsString);
		}

		public virtual void ListSuggestedUsers(string categorySlug, Action<TwitterUserSuggestions, TwitterResponse> action)
		{
			WithHammock(action, "/users/suggestions/{category_slug}", FormatAsString, "?category_slug=", categorySlug);
		}

		#endregion
#endif	
	}

	#endregion
}
